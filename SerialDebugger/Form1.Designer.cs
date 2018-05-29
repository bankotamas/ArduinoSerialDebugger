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
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.databits_tSlabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.parity_tSlabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel11 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stopbit_tSlabel = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DataMonitorSettings_gbox = new System.Windows.Forms.GroupBox();
            this.dataSetIndex_tbox = new System.Windows.Forms.TextBox();
            this.modifyDataSet_btn = new System.Windows.Forms.Button();
            this.loadDataSet_btn = new System.Windows.Forms.Button();
            this.saveDataSet_btn = new System.Windows.Forms.Button();
            this.dataSetUnit_tbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataSetID_tbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataSetName_tbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addDataSet_btn = new System.Windows.Forms.Button();
            this.serialPortAliveTimer = new System.Windows.Forms.Timer(this.components);
            this.deleteDataSet_btn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.DataMonitorSettings_gbox.SuspendLayout();
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
            this.baudrate_tSlabel,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.databits_tSlabel,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel9,
            this.parity_tSlabel,
            this.toolStripStatusLabel10,
            this.toolStripStatusLabel11,
            this.stopbit_tSlabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 320);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(646, 22);
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
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel6.Text = " | ";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(51, 17);
            this.toolStripStatusLabel7.Text = "DataBit: ";
            // 
            // databits_tSlabel
            // 
            this.databits_tSlabel.Name = "databits_tSlabel";
            this.databits_tSlabel.Size = new System.Drawing.Size(18, 17);
            this.databits_tSlabel.Text = " - ";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel8.Text = " | ";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel9.Text = "Parity: ";
            // 
            // parity_tSlabel
            // 
            this.parity_tSlabel.Name = "parity_tSlabel";
            this.parity_tSlabel.Size = new System.Drawing.Size(18, 17);
            this.parity_tSlabel.Text = " - ";
            // 
            // toolStripStatusLabel10
            // 
            this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            this.toolStripStatusLabel10.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel10.Text = " | ";
            // 
            // toolStripStatusLabel11
            // 
            this.toolStripStatusLabel11.Name = "toolStripStatusLabel11";
            this.toolStripStatusLabel11.Size = new System.Drawing.Size(51, 17);
            this.toolStripStatusLabel11.Text = "StopBit: ";
            // 
            // stopbit_tSlabel
            // 
            this.stopbit_tSlabel.Name = "stopbit_tSlabel";
            this.stopbit_tSlabel.Size = new System.Drawing.Size(18, 17);
            this.stopbit_tSlabel.Text = " - ";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(622, 305);
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
            this.tabPage1.Size = new System.Drawing.Size(614, 279);
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
            this.settings_lbox.SelectedIndexChanged += new System.EventHandler(this.settings_lbox_SelectedIndexChanged);
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
            this.tabPage2.Size = new System.Drawing.Size(614, 279);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flowLayoutPanel1);
            this.tabPage3.Controls.Add(this.DataMonitorSettings_gbox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(614, 279);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Data Monitor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 84);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(602, 189);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // DataMonitorSettings_gbox
            // 
            this.DataMonitorSettings_gbox.Controls.Add(this.deleteDataSet_btn);
            this.DataMonitorSettings_gbox.Controls.Add(this.dataSetIndex_tbox);
            this.DataMonitorSettings_gbox.Controls.Add(this.modifyDataSet_btn);
            this.DataMonitorSettings_gbox.Controls.Add(this.loadDataSet_btn);
            this.DataMonitorSettings_gbox.Controls.Add(this.saveDataSet_btn);
            this.DataMonitorSettings_gbox.Controls.Add(this.dataSetUnit_tbox);
            this.DataMonitorSettings_gbox.Controls.Add(this.label8);
            this.DataMonitorSettings_gbox.Controls.Add(this.dataSetID_tbox);
            this.DataMonitorSettings_gbox.Controls.Add(this.label7);
            this.DataMonitorSettings_gbox.Controls.Add(this.dataSetName_tbox);
            this.DataMonitorSettings_gbox.Controls.Add(this.label6);
            this.DataMonitorSettings_gbox.Controls.Add(this.addDataSet_btn);
            this.DataMonitorSettings_gbox.Location = new System.Drawing.Point(6, 3);
            this.DataMonitorSettings_gbox.Name = "DataMonitorSettings_gbox";
            this.DataMonitorSettings_gbox.Size = new System.Drawing.Size(602, 75);
            this.DataMonitorSettings_gbox.TabIndex = 0;
            this.DataMonitorSettings_gbox.TabStop = false;
            this.DataMonitorSettings_gbox.Text = "Settings";
            // 
            // dataSetIndex_tbox
            // 
            this.dataSetIndex_tbox.Location = new System.Drawing.Point(168, 48);
            this.dataSetIndex_tbox.Name = "dataSetIndex_tbox";
            this.dataSetIndex_tbox.Size = new System.Drawing.Size(23, 20);
            this.dataSetIndex_tbox.TabIndex = 10;
            this.dataSetIndex_tbox.Visible = false;
            // 
            // modifyDataSet_btn
            // 
            this.modifyDataSet_btn.Location = new System.Drawing.Point(521, 17);
            this.modifyDataSet_btn.Name = "modifyDataSet_btn";
            this.modifyDataSet_btn.Size = new System.Drawing.Size(75, 23);
            this.modifyDataSet_btn.TabIndex = 9;
            this.modifyDataSet_btn.Text = "Modify";
            this.modifyDataSet_btn.UseVisualStyleBackColor = true;
            this.modifyDataSet_btn.Click += new System.EventHandler(this.modifyDataSet_btn_Click);
            // 
            // loadDataSet_btn
            // 
            this.loadDataSet_btn.Location = new System.Drawing.Point(6, 46);
            this.loadDataSet_btn.Name = "loadDataSet_btn";
            this.loadDataSet_btn.Size = new System.Drawing.Size(75, 23);
            this.loadDataSet_btn.TabIndex = 8;
            this.loadDataSet_btn.Text = "Load";
            this.loadDataSet_btn.UseVisualStyleBackColor = true;
            // 
            // saveDataSet_btn
            // 
            this.saveDataSet_btn.Location = new System.Drawing.Point(87, 46);
            this.saveDataSet_btn.Name = "saveDataSet_btn";
            this.saveDataSet_btn.Size = new System.Drawing.Size(75, 23);
            this.saveDataSet_btn.TabIndex = 7;
            this.saveDataSet_btn.Text = "Save";
            this.saveDataSet_btn.UseVisualStyleBackColor = true;
            // 
            // dataSetUnit_tbox
            // 
            this.dataSetUnit_tbox.Location = new System.Drawing.Point(405, 19);
            this.dataSetUnit_tbox.Name = "dataSetUnit_tbox";
            this.dataSetUnit_tbox.Size = new System.Drawing.Size(100, 20);
            this.dataSetUnit_tbox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Unit:";
            // 
            // dataSetID_tbox
            // 
            this.dataSetID_tbox.Location = new System.Drawing.Point(264, 19);
            this.dataSetID_tbox.Name = "dataSetID_tbox";
            this.dataSetID_tbox.Size = new System.Drawing.Size(100, 20);
            this.dataSetID_tbox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "ID:";
            // 
            // dataSetName_tbox
            // 
            this.dataSetName_tbox.Location = new System.Drawing.Point(131, 19);
            this.dataSetName_tbox.Name = "dataSetName_tbox";
            this.dataSetName_tbox.Size = new System.Drawing.Size(100, 20);
            this.dataSetName_tbox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Name:";
            // 
            // addDataSet_btn
            // 
            this.addDataSet_btn.Location = new System.Drawing.Point(6, 17);
            this.addDataSet_btn.Name = "addDataSet_btn";
            this.addDataSet_btn.Size = new System.Drawing.Size(75, 23);
            this.addDataSet_btn.TabIndex = 0;
            this.addDataSet_btn.Text = "Add";
            this.addDataSet_btn.UseVisualStyleBackColor = true;
            this.addDataSet_btn.Click += new System.EventHandler(this.addDataSet_btn_Click);
            // 
            // serialPortAliveTimer
            // 
            this.serialPortAliveTimer.Tick += new System.EventHandler(this.serialPortAlive_Tick);
            // 
            // deleteDataSet_btn
            // 
            this.deleteDataSet_btn.Location = new System.Drawing.Point(521, 46);
            this.deleteDataSet_btn.Name = "deleteDataSet_btn";
            this.deleteDataSet_btn.Size = new System.Drawing.Size(75, 23);
            this.deleteDataSet_btn.TabIndex = 11;
            this.deleteDataSet_btn.Text = "Delete";
            this.deleteDataSet_btn.UseVisualStyleBackColor = true;
            this.deleteDataSet_btn.Click += new System.EventHandler(this.deleteDataSet_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 342);
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
            this.tabPage3.ResumeLayout(false);
            this.DataMonitorSettings_gbox.ResumeLayout(false);
            this.DataMonitorSettings_gbox.PerformLayout();
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
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel databits_tSlabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel parity_tSlabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel11;
        private System.Windows.Forms.ToolStripStatusLabel stopbit_tSlabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox DataMonitorSettings_gbox;
        private System.Windows.Forms.TextBox dataSetID_tbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dataSetName_tbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addDataSet_btn;
        private System.Windows.Forms.TextBox dataSetUnit_tbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button loadDataSet_btn;
        private System.Windows.Forms.Button saveDataSet_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button modifyDataSet_btn;
        private System.Windows.Forms.TextBox dataSetIndex_tbox;
        private System.Windows.Forms.Button deleteDataSet_btn;
    }
}

