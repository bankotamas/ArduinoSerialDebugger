namespace SerialDebugger
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comport_cbox = new System.Windows.Forms.ComboBox();
            this.baudrate_cbox = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.connection_status_tSlabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.connected_comport_tSlabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.baudrate_tSlabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.deleteSettings_btn = new System.Windows.Forms.Button();
            this.settingsName_tbox = new System.Windows.Forms.TextBox();
            this.loadSettings_btn = new System.Windows.Forms.Button();
            this.saveSettings_btn = new System.Windows.Forms.Button();
            this.settings_lbox = new System.Windows.Forms.ListBox();
            this.stopbit_cbox = new System.Windows.Forms.ComboBox();
            this.parity_cbox = new System.Windows.Forms.ComboBox();
            this.databit_cbox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.disconnect_btn = new System.Windows.Forms.Button();
            this.connect_btn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sendCommand_btn = new System.Windows.Forms.Button();
            this.command_tbox = new System.Windows.Forms.TextBox();
            this.serialMonitor_rtbox = new System.Windows.Forms.RichTextBox();
            this.serialPortAliveTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ComPort:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "BaudRate:";
            // 
            // comport_cbox
            // 
            this.comport_cbox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comport_cbox.FormattingEnabled = true;
            this.comport_cbox.Location = new System.Drawing.Point(72, 12);
            this.comport_cbox.Name = "comport_cbox";
            this.comport_cbox.Size = new System.Drawing.Size(121, 23);
            this.comport_cbox.TabIndex = 3;
            this.comport_cbox.Click += new System.EventHandler(this.comport_cbox_Click);
            // 
            // baudrate_cbox
            // 
            this.baudrate_cbox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.baudrate_cbox.FormattingEnabled = true;
            this.baudrate_cbox.Location = new System.Drawing.Point(72, 44);
            this.baudrate_cbox.Name = "baudrate_cbox";
            this.baudrate_cbox.Size = new System.Drawing.Size(121, 23);
            this.baudrate_cbox.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.connection_status_tSlabel,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2,
            this.connected_comport_tSlabel,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.baudrate_tSlabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 320);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Status: ";
            // 
            // connection_status_tSlabel
            // 
            this.connection_status_tSlabel.Name = "connection_status_tSlabel";
            this.connection_status_tSlabel.Size = new System.Drawing.Size(79, 17);
            this.connection_status_tSlabel.Text = "Disconnected";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel3.Text = " | ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(61, 17);
            this.toolStripStatusLabel2.Text = "ComPort: ";
            // 
            // connected_comport_tSlabel
            // 
            this.connected_comport_tSlabel.Name = "connected_comport_tSlabel";
            this.connected_comport_tSlabel.Size = new System.Drawing.Size(18, 17);
            this.connected_comport_tSlabel.Text = " - ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel4.Text = " | ";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel5.Text = "BaudRate: ";
            // 
            // baudrate_tSlabel
            // 
            this.baudrate_tSlabel.Name = "baudrate_tSlabel";
            this.baudrate_tSlabel.Size = new System.Drawing.Size(18, 17);
            this.baudrate_tSlabel.Text = " - ";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 305);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.deleteSettings_btn);
            this.tabPage1.Controls.Add(this.settingsName_tbox);
            this.tabPage1.Controls.Add(this.loadSettings_btn);
            this.tabPage1.Controls.Add(this.saveSettings_btn);
            this.tabPage1.Controls.Add(this.settings_lbox);
            this.tabPage1.Controls.Add(this.stopbit_cbox);
            this.tabPage1.Controls.Add(this.parity_cbox);
            this.tabPage1.Controls.Add(this.databit_cbox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.disconnect_btn);
            this.tabPage1.Controls.Add(this.baudrate_cbox);
            this.tabPage1.Controls.Add(this.connect_btn);
            this.tabPage1.Controls.Add(this.comport_cbox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // deleteSettings_btn
            // 
            this.deleteSettings_btn.Location = new System.Drawing.Point(290, 177);
            this.deleteSettings_btn.Name = "deleteSettings_btn";
            this.deleteSettings_btn.Size = new System.Drawing.Size(75, 23);
            this.deleteSettings_btn.TabIndex = 16;
            this.deleteSettings_btn.Text = "Delete";
            this.deleteSettings_btn.UseVisualStyleBackColor = true;
            this.deleteSettings_btn.Click += new System.EventHandler(this.deleteSettings_btn_Click);
            // 
            // settingsName_tbox
            // 
            this.settingsName_tbox.Location = new System.Drawing.Point(280, 150);
            this.settingsName_tbox.Name = "settingsName_tbox";
            this.settingsName_tbox.Size = new System.Drawing.Size(97, 20);
            this.settingsName_tbox.TabIndex = 15;
            // 
            // loadSettings_btn
            // 
            this.loadSettings_btn.Location = new System.Drawing.Point(199, 177);
            this.loadSettings_btn.Name = "loadSettings_btn";
            this.loadSettings_btn.Size = new System.Drawing.Size(75, 23);
            this.loadSettings_btn.TabIndex = 14;
            this.loadSettings_btn.Text = "Load";
            this.loadSettings_btn.UseVisualStyleBackColor = true;
            this.loadSettings_btn.Click += new System.EventHandler(this.loadSettings_btn_Click);
            // 
            // saveSettings_btn
            // 
            this.saveSettings_btn.Location = new System.Drawing.Point(199, 148);
            this.saveSettings_btn.Name = "saveSettings_btn";
            this.saveSettings_btn.Size = new System.Drawing.Size(75, 23);
            this.saveSettings_btn.TabIndex = 13;
            this.saveSettings_btn.Text = "Save";
            this.saveSettings_btn.UseVisualStyleBackColor = true;
            this.saveSettings_btn.Click += new System.EventHandler(this.saveSettings_btn_Click);
            // 
            // settings_lbox
            // 
            this.settings_lbox.FormattingEnabled = true;
            this.settings_lbox.Location = new System.Drawing.Point(199, 12);
            this.settings_lbox.Name = "settings_lbox";
            this.settings_lbox.Size = new System.Drawing.Size(178, 121);
            this.settings_lbox.TabIndex = 12;
            // 
            // stopbit_cbox
            // 
            this.stopbit_cbox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopbit_cbox.FormattingEnabled = true;
            this.stopbit_cbox.Location = new System.Drawing.Point(72, 139);
            this.stopbit_cbox.Name = "stopbit_cbox";
            this.stopbit_cbox.Size = new System.Drawing.Size(121, 23);
            this.stopbit_cbox.TabIndex = 11;
            // 
            // parity_cbox
            // 
            this.parity_cbox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parity_cbox.FormattingEnabled = true;
            this.parity_cbox.Location = new System.Drawing.Point(72, 108);
            this.parity_cbox.Name = "parity_cbox";
            this.parity_cbox.Size = new System.Drawing.Size(121, 23);
            this.parity_cbox.TabIndex = 10;
            // 
            // databit_cbox
            // 
            this.databit_cbox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.databit_cbox.FormattingEnabled = true;
            this.databit_cbox.Location = new System.Drawing.Point(72, 76);
            this.databit_cbox.Name = "databit_cbox";
            this.databit_cbox.Size = new System.Drawing.Size(121, 23);
            this.databit_cbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stop bit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data bit:";
            // 
            // disconnect_btn
            // 
            this.disconnect_btn.Location = new System.Drawing.Point(108, 177);
            this.disconnect_btn.Name = "disconnect_btn";
            this.disconnect_btn.Size = new System.Drawing.Size(75, 23);
            this.disconnect_btn.TabIndex = 5;
            this.disconnect_btn.Text = "Disconnect";
            this.disconnect_btn.UseVisualStyleBackColor = true;
            this.disconnect_btn.Click += new System.EventHandler(this.disconnect_btn_Click);
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(18, 177);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(75, 23);
            this.connect_btn.TabIndex = 1;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sendCommand_btn);
            this.tabPage2.Controls.Add(this.command_tbox);
            this.tabPage2.Controls.Add(this.serialMonitor_rtbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Serial Monitor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sendCommand_btn
            // 
            this.sendCommand_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sendCommand_btn.Location = new System.Drawing.Point(6, 251);
            this.sendCommand_btn.Name = "sendCommand_btn";
            this.sendCommand_btn.Size = new System.Drawing.Size(75, 23);
            this.sendCommand_btn.TabIndex = 2;
            this.sendCommand_btn.Text = "Send";
            this.sendCommand_btn.UseVisualStyleBackColor = true;
            this.sendCommand_btn.Click += new System.EventHandler(this.sendCommand_btn_Click);
            // 
            // command_tbox
            // 
            this.command_tbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.command_tbox.Location = new System.Drawing.Point(87, 253);
            this.command_tbox.Name = "command_tbox";
            this.command_tbox.Size = new System.Drawing.Size(499, 20);
            this.command_tbox.TabIndex = 1;
            // 
            // serialMonitor_rtbox
            // 
            this.serialMonitor_rtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialMonitor_rtbox.Location = new System.Drawing.Point(6, 6);
            this.serialMonitor_rtbox.Name = "serialMonitor_rtbox";
            this.serialMonitor_rtbox.Size = new System.Drawing.Size(580, 241);
            this.serialMonitor_rtbox.TabIndex = 0;
            this.serialMonitor_rtbox.Text = "";
            // 
            // serialPortAliveTimer
            // 
            this.serialPortAliveTimer.Tick += new System.EventHandler(this.serialPortAlive_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 342);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 380);
            this.Name = "Form1";
            this.Text = "Serial Debugger";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comport_cbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox baudrate_cbox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel connection_status_tSlabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel connected_comport_tSlabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel baudrate_tSlabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox stopbit_cbox;
        private System.Windows.Forms.ComboBox parity_cbox;
        private System.Windows.Forms.ComboBox databit_cbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button disconnect_btn;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.RichTextBox serialMonitor_rtbox;
        private System.Windows.Forms.Button sendCommand_btn;
        private System.Windows.Forms.TextBox command_tbox;
        private System.Windows.Forms.Timer serialPortAliveTimer;
        private System.Windows.Forms.TextBox settingsName_tbox;
        private System.Windows.Forms.Button loadSettings_btn;
        private System.Windows.Forms.Button saveSettings_btn;
        private System.Windows.Forms.ListBox settings_lbox;
        private System.Windows.Forms.Button deleteSettings_btn;
    }
}

