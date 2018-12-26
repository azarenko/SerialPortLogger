namespace SerialPortLogger
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._portName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this._portBaudRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this._portStopBits = new System.Windows.Forms.ComboBox();
            this.connect = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._portParity = new System.Windows.Forms.ComboBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this._filePath = new System.Windows.Forms.TextBox();
            this._openFile = new System.Windows.Forms.Button();
            this._info = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._portBaudRate)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 168);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(444, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _statusLabel
            // 
            this._statusLabel.Name = "_statusLabel";
            this._statusLabel.Size = new System.Drawing.Size(79, 17);
            this._statusLabel.Text = "Disconnected";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 168);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._info);
            this.groupBox1.Controls.Add(this._portParity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.disconnect);
            this.groupBox1.Controls.Add(this.connect);
            this.groupBox1.Controls.Add(this._portStopBits);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._portBaudRate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._portName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._openFile);
            this.groupBox2.Controls.Add(this._filePath);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File settings";
            // 
            // _portName
            // 
            this._portName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._portName.FormattingEnabled = true;
            this._portName.Location = new System.Drawing.Point(73, 19);
            this._portName.Name = "_portName";
            this._portName.Size = new System.Drawing.Size(97, 21);
            this._portName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port name:";
            // 
            // _portBaudRate
            // 
            this._portBaudRate.Location = new System.Drawing.Point(73, 46);
            this._portBaudRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this._portBaudRate.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this._portBaudRate.Name = "_portBaudRate";
            this._portBaudRate.Size = new System.Drawing.Size(97, 20);
            this._portBaudRate.TabIndex = 2;
            this._portBaudRate.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud rate:";
            // 
            // _portStopBits
            // 
            this._portStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._portStopBits.FormattingEnabled = true;
            this._portStopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "1.5"});
            this._portStopBits.Location = new System.Drawing.Point(230, 19);
            this._portStopBits.Name = "_portStopBits";
            this._portStopBits.Size = new System.Drawing.Size(97, 21);
            this._portStopBits.TabIndex = 4;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(12, 72);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 5;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(95, 72);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(75, 23);
            this.disconnect.TabIndex = 6;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stop bits:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parity:";
            // 
            // _portParity
            // 
            this._portParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._portParity.FormattingEnabled = true;
            this._portParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this._portParity.Location = new System.Drawing.Point(230, 45);
            this._portParity.Name = "_portParity";
            this._portParity.Size = new System.Drawing.Size(97, 21);
            this._portParity.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Path:";
            // 
            // _filePath
            // 
            this._filePath.Location = new System.Drawing.Point(47, 19);
            this._filePath.Name = "_filePath";
            this._filePath.Size = new System.Drawing.Size(335, 20);
            this._filePath.TabIndex = 1;
            // 
            // _openFile
            // 
            this._openFile.Location = new System.Drawing.Point(388, 17);
            this._openFile.Name = "_openFile";
            this._openFile.Size = new System.Drawing.Size(42, 23);
            this._openFile.TabIndex = 2;
            this._openFile.Text = "...";
            this._openFile.UseVisualStyleBackColor = true;
            this._openFile.Click += new System.EventHandler(this._openFile_Click);
            // 
            // _info
            // 
            this._info.AutoSize = true;
            this._info.Location = new System.Drawing.Point(176, 77);
            this._info.Name = "_info";
            this._info.Size = new System.Drawing.Size(0, 13);
            this._info.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 190);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Serial port logger (by Azarenko S.A.)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._portBaudRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _statusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _portName;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown _portBaudRate;
        private System.Windows.Forms.ComboBox _portStopBits;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Button connect;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _portParity;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button _openFile;
        private System.Windows.Forms.TextBox _filePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _info;
    }
}

