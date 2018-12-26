using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SerialPortLogger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (string portName in SerialPort.GetPortNames())
            {
                _portName.Items.Add(portName);
            }

            _portStopBits.SelectedIndex = 0;
            _portParity.SelectedIndex = 0;

            backgroundWorker.RunWorkerAsync();
        }        

        private void connect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_portName.Text))
            {
                MessageBox.Show("Choose port before you connect to the port");
                return;
            }

            if (string.IsNullOrEmpty(_filePath.Text))
            {
                MessageBox.Show("Choose file before you connect to the port");
                return;
            }

            if (!serialPort.IsOpen)
            {
                serialPort.PortName = _portName.Text;
                serialPort.BaudRate = (int)_portBaudRate.Value;
                serialPort.StopBits = (StopBits)Enum.GetValues(typeof(StopBits)).GetValue(_portStopBits.SelectedIndex + 1);
                serialPort.Parity = (Parity)Enum.GetValues(typeof(Parity)).GetValue(_portParity.SelectedIndex);
                serialPort.ReadTimeout = 1000;

                serialPort.Open();
                _statusLabel.Text = "Connected";
            }
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                _statusLabel.Text = "Disconnected";
            }
        }

        private delegate void SetInfoLabelDelegate(string message);
        private void SetInfoLabel(string message)
        {
            if (_info.InvokeRequired)
            {
                _info.Invoke(new SetInfoLabelDelegate(SetInfoLabel), message);
            }
            else
            {
                _info.Text = message;
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            FileStream fbin = null;
            StreamWriter fhex = null;
            StreamWriter fhextime = null;
            ulong readedBytes = 0;

            do
            {
                if (serialPort.IsOpen)
                {
                    if (fbin == null)
                    {
                        fbin = new FileStream(_filePath.Text + ".bin", FileMode.OpenOrCreate);
                        fbin.Seek(0, SeekOrigin.End);
                        readedBytes = 0;
                    }
                    if (fhex == null)
                    {
                        fhex = new StreamWriter(_filePath.Text + ".hex", true);
                    }
                    if (fhextime == null)
                    {
                        fhextime = new StreamWriter(_filePath.Text + ".hextime", true);
                    }

                    while (serialPort.IsOpen)
                    {
                        byte b;
                        try
                        {
                            b = (byte)serialPort.ReadByte();
                            DateTime dt = DateTime.Now;

                            fbin.WriteByte(b);
                            fhex.Write(b.ToString("X2"));
                            fhextime.WriteLine(string.Format("{0}: {1}", dt.ToString("dd.MM.yyyy hh:mm:ss.ffff"), b.ToString("X2")));
                            SetInfoLabel(string.Format("Readed bytes: {0}", ++readedBytes));
                        }
                        catch (TimeoutException)
                        {
                            if (fbin != null)
                            {
                                fbin.Flush();
                            }
                            if (fhex != null)
                            {
                                fhex.Flush();
                            }
                            if (fhextime != null)
                            {
                                fhextime.Flush();
                            }
                        }
                        catch (IOException)
                        {
                            if (!serialPort.IsOpen)
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    if (fbin != null)
                    {
                        fbin.Flush();
                        fbin.Close();
                        fbin = null;
                    }

                    if (fhex != null)
                    {
                        fhex.Flush();
                        fhex.Close();
                        fhex = null;
                    }

                    if (fhextime != null)
                    {
                        fhextime.Flush();
                        fhextime.Close();
                        fhextime = null;
                    }

                    Thread.Sleep(100);
                }
            }
            while (true);
        }        

        private void _openFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _filePath.Text = saveFileDialog.FileName;
            }
        }
    }
}
