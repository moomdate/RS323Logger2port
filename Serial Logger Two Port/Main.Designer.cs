namespace Serial_Logger_Two_Port
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Display1 = new System.Windows.Forms.RichTextBox();
            this.Connect1 = new System.Windows.Forms.Button();
            this.Timelog1 = new System.Windows.Forms.RichTextBox();
            this.buadrate1 = new System.Windows.Forms.ComboBox();
            this.newlineChbox1 = new System.Windows.Forms.CheckBox();
            this.type1 = new System.Windows.Forms.ComboBox();
            this.Port1 = new System.Windows.Forms.ComboBox();
            this.Timelog2 = new System.Windows.Forms.RichTextBox();
            this.refreshBtn1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Display2 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Autoscroll1 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.statusSerial1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.StopSave1 = new System.Windows.Forms.Button();
            this.LocationLink1 = new System.Windows.Forms.LinkLabel();
            this.saveTime1 = new System.Windows.Forms.CheckBox();
            this.SavelogBtn1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.StopSave2 = new System.Windows.Forms.Button();
            this.LocationLink2 = new System.Windows.Forms.LinkLabel();
            this.saveTime2 = new System.Windows.Forms.CheckBox();
            this.SavelogBtn2 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Connect2 = new System.Windows.Forms.Button();
            this.Autoscroll2 = new System.Windows.Forms.CheckBox();
            this.newlineChbox2 = new System.Windows.Forms.CheckBox();
            this.refreshBtn2 = new System.Windows.Forms.Button();
            this.buadrate2 = new System.Windows.Forms.ComboBox();
            this.type2 = new System.Windows.Forms.ComboBox();
            this.Port2 = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.statusSerial2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.clear1 = new System.Windows.Forms.Button();
            this.inputSerial1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.typeS1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.inputSerial2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.typeS2 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveLog1 = new System.Windows.Forms.SaveFileDialog();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.SaveLog2 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusSerial1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusSerial2)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Display1
            // 
            this.Display1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(233)))), ((int)(((byte)(247)))));
            this.Display1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Display1.Location = new System.Drawing.Point(3, 162);
            this.Display1.Name = "Display1";
            this.Display1.Size = new System.Drawing.Size(400, 225);
            this.Display1.TabIndex = 0;
            this.Display1.Text = "";
            this.Display1.TextChanged += new System.EventHandler(this.Display1_TextChanged);
            // 
            // Connect1
            // 
            this.Connect1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Connect1.FlatAppearance.BorderSize = 0;
            this.Connect1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connect1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Connect1.Location = new System.Drawing.Point(246, 13);
            this.Connect1.Name = "Connect1";
            this.Connect1.Size = new System.Drawing.Size(72, 29);
            this.Connect1.TabIndex = 2;
            this.Connect1.Text = "Connect";
            this.Connect1.UseVisualStyleBackColor = false;
            this.Connect1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Timelog1
            // 
            this.Timelog1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Timelog1.Location = new System.Drawing.Point(409, 162);
            this.Timelog1.Name = "Timelog1";
            this.Timelog1.Size = new System.Drawing.Size(77, 225);
            this.Timelog1.TabIndex = 5;
            this.Timelog1.Text = "";
            this.Timelog1.TextChanged += new System.EventHandler(this.Timelog1_TextChanged);
            // 
            // buadrate1
            // 
            this.buadrate1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.buadrate1.FormattingEnabled = true;
            this.buadrate1.Items.AddRange(new object[] {
            "110",
            "600",
            "2400",
            "9600",
            "19200",
            "38400",
            "57600",
            "128000",
            "230400",
            "460800"});
            this.buadrate1.Location = new System.Drawing.Point(162, 13);
            this.buadrate1.Name = "buadrate1";
            this.buadrate1.Size = new System.Drawing.Size(83, 29);
            this.buadrate1.TabIndex = 6;
            // 
            // newlineChbox1
            // 
            this.newlineChbox1.AutoSize = true;
            this.newlineChbox1.Location = new System.Drawing.Point(99, 64);
            this.newlineChbox1.Name = "newlineChbox1";
            this.newlineChbox1.Size = new System.Drawing.Size(71, 17);
            this.newlineChbox1.TabIndex = 7;
            this.newlineChbox1.Text = "New Line";
            this.newlineChbox1.UseVisualStyleBackColor = true;
            this.newlineChbox1.CheckStateChanged += new System.EventHandler(this.newlineChbox_CheckStateChanged);
            // 
            // type1
            // 
            this.type1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.type1.FormattingEnabled = true;
            this.type1.Items.AddRange(new object[] {
            "Normal",
            "Dec",
            "HEX"});
            this.type1.Location = new System.Drawing.Point(10, 48);
            this.type1.Name = "type1";
            this.type1.Size = new System.Drawing.Size(83, 29);
            this.type1.TabIndex = 8;
            // 
            // Port1
            // 
            this.Port1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.Port1.FormattingEnabled = true;
            this.Port1.Location = new System.Drawing.Point(10, 13);
            this.Port1.Name = "Port1";
            this.Port1.Size = new System.Drawing.Size(84, 29);
            this.Port1.TabIndex = 6;
            // 
            // Timelog2
            // 
            this.Timelog2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Timelog2.Location = new System.Drawing.Point(492, 162);
            this.Timelog2.Name = "Timelog2";
            this.Timelog2.Size = new System.Drawing.Size(79, 225);
            this.Timelog2.TabIndex = 0;
            this.Timelog2.Text = "";
            this.Timelog2.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // refreshBtn1
            // 
            this.refreshBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(142)))), ((int)(((byte)(219)))));
            this.refreshBtn1.FlatAppearance.BorderSize = 0;
            this.refreshBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.refreshBtn1.Location = new System.Drawing.Point(95, 13);
            this.refreshBtn1.Name = "refreshBtn1";
            this.refreshBtn1.Size = new System.Drawing.Size(62, 29);
            this.refreshBtn1.TabIndex = 9;
            this.refreshBtn1.Text = "Refresh";
            this.refreshBtn1.UseVisualStyleBackColor = false;
            this.refreshBtn1.Click += new System.EventHandler(this.refreshBtn1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.35644F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.549611F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.737514F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.35644F));
            this.tableLayoutPanel1.Controls.Add(this.Display2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Timelog1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Display1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Timelog2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.81633F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.18367F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 424);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // Display2
            // 
            this.Display2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(249)))), ((int)(((byte)(179)))));
            this.Display2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Display2.Location = new System.Drawing.Point(577, 162);
            this.Display2.Name = "Display2";
            this.Display2.Size = new System.Drawing.Size(402, 225);
            this.Display2.TabIndex = 11;
            this.Display2.Text = "";
            this.Display2.TextChanged += new System.EventHandler(this.Display2_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.56281F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.43719F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.85542F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.14458F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 153);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.Connect1);
            this.panel1.Controls.Add(this.Autoscroll1);
            this.panel1.Controls.Add(this.newlineChbox1);
            this.panel1.Controls.Add(this.refreshBtn1);
            this.panel1.Controls.Add(this.buadrate1);
            this.panel1.Controls.Add(this.type1);
            this.panel1.Controls.Add(this.Port1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(50, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 97);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Autoscroll1
            // 
            this.Autoscroll1.AutoSize = true;
            this.Autoscroll1.Location = new System.Drawing.Point(99, 48);
            this.Autoscroll1.Name = "Autoscroll1";
            this.Autoscroll1.Size = new System.Drawing.Size(77, 17);
            this.Autoscroll1.TabIndex = 7;
            this.Autoscroll1.Text = "Auto Scroll";
            this.Autoscroll1.UseVisualStyleBackColor = true;
            this.Autoscroll1.CheckStateChanged += new System.EventHandler(this.Autoscroll_CheckStateChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.statusSerial1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 97);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status";
            // 
            // statusSerial1
            // 
            this.statusSerial1.BackgroundImage = global::Serial_Logger_Two_Port.Resource1.discon;
            this.statusSerial1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusSerial1.InitialImage = null;
            this.statusSerial1.Location = new System.Drawing.Point(6, 40);
            this.statusSerial1.Name = "statusSerial1";
            this.statusSerial1.Size = new System.Drawing.Size(41, 41);
            this.statusSerial1.TabIndex = 3;
            this.statusSerial1.TabStop = false;
            this.statusSerial1.UseWaitCursor = true;
            this.statusSerial1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.StopSave1);
            this.panel3.Controls.Add(this.LocationLink1);
            this.panel3.Controls.Add(this.saveTime1);
            this.panel3.Controls.Add(this.SavelogBtn1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(50, 97);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 56);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Location File:";
            // 
            // StopSave1
            // 
            this.StopSave1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.StopSave1.Enabled = false;
            this.StopSave1.FlatAppearance.BorderSize = 0;
            this.StopSave1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopSave1.Location = new System.Drawing.Point(81, 3);
            this.StopSave1.Name = "StopSave1";
            this.StopSave1.Size = new System.Drawing.Size(46, 27);
            this.StopSave1.TabIndex = 12;
            this.StopSave1.Text = "Stop";
            this.StopSave1.UseVisualStyleBackColor = false;
            this.StopSave1.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // LocationLink1
            // 
            this.LocationLink1.AutoSize = true;
            this.LocationLink1.Location = new System.Drawing.Point(145, 37);
            this.LocationLink1.Name = "LocationLink1";
            this.LocationLink1.Size = new System.Drawing.Size(25, 13);
            this.LocationLink1.TabIndex = 11;
            this.LocationLink1.TabStop = true;
            this.LocationLink1.Text = "Null";
            this.LocationLink1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LocationLink1_LinkClicked);
            this.LocationLink1.Click += new System.EventHandler(this.LocationLink_Click);
            // 
            // saveTime1
            // 
            this.saveTime1.AutoSize = true;
            this.saveTime1.Enabled = false;
            this.saveTime1.Location = new System.Drawing.Point(3, 36);
            this.saveTime1.Name = "saveTime1";
            this.saveTime1.Size = new System.Drawing.Size(77, 17);
            this.saveTime1.TabIndex = 10;
            this.saveTime1.Text = "Save Time";
            this.saveTime1.UseVisualStyleBackColor = true;
            this.saveTime1.CheckedChanged += new System.EventHandler(this.saveTime_CheckedChanged);
            // 
            // SavelogBtn1
            // 
            this.SavelogBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(137)))));
            this.SavelogBtn1.FlatAppearance.BorderSize = 0;
            this.SavelogBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavelogBtn1.Location = new System.Drawing.Point(3, 3);
            this.SavelogBtn1.Name = "SavelogBtn1";
            this.SavelogBtn1.Size = new System.Drawing.Size(72, 26);
            this.SavelogBtn1.TabIndex = 3;
            this.SavelogBtn1.Text = "Save Log";
            this.SavelogBtn1.UseVisualStyleBackColor = false;
            this.SavelogBtn1.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.2963F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.7037F));
            this.tableLayoutPanel3.Controls.Add(this.panel7, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(577, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.35947F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.64052F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(402, 153);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.StopSave2);
            this.panel7.Controls.Add(this.LocationLink2);
            this.panel7.Controls.Add(this.saveTime2);
            this.panel7.Controls.Add(this.SavelogBtn2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(65, 99);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(337, 54);
            this.panel7.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Location File:";
            // 
            // StopSave2
            // 
            this.StopSave2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.StopSave2.Enabled = false;
            this.StopSave2.FlatAppearance.BorderSize = 0;
            this.StopSave2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopSave2.Location = new System.Drawing.Point(81, 1);
            this.StopSave2.Name = "StopSave2";
            this.StopSave2.Size = new System.Drawing.Size(46, 27);
            this.StopSave2.TabIndex = 12;
            this.StopSave2.Text = "Stop";
            this.StopSave2.UseVisualStyleBackColor = false;
            this.StopSave2.Click += new System.EventHandler(this.StopSave2_Click);
            // 
            // LocationLink2
            // 
            this.LocationLink2.AutoSize = true;
            this.LocationLink2.Location = new System.Drawing.Point(145, 35);
            this.LocationLink2.Name = "LocationLink2";
            this.LocationLink2.Size = new System.Drawing.Size(25, 13);
            this.LocationLink2.TabIndex = 11;
            this.LocationLink2.TabStop = true;
            this.LocationLink2.Text = "Null";
            this.LocationLink2.Click += new System.EventHandler(this.LocationLink2_Click);
            // 
            // saveTime2
            // 
            this.saveTime2.AutoSize = true;
            this.saveTime2.Enabled = false;
            this.saveTime2.Location = new System.Drawing.Point(3, 33);
            this.saveTime2.Name = "saveTime2";
            this.saveTime2.Size = new System.Drawing.Size(77, 17);
            this.saveTime2.TabIndex = 10;
            this.saveTime2.Text = "Save Time";
            this.saveTime2.UseVisualStyleBackColor = true;
            this.saveTime2.CheckedChanged += new System.EventHandler(this.saveTime2_CheckedChanged);
            // 
            // SavelogBtn2
            // 
            this.SavelogBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(137)))));
            this.SavelogBtn2.FlatAppearance.BorderSize = 0;
            this.SavelogBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavelogBtn2.Location = new System.Drawing.Point(3, 2);
            this.SavelogBtn2.Name = "SavelogBtn2";
            this.SavelogBtn2.Size = new System.Drawing.Size(72, 26);
            this.SavelogBtn2.TabIndex = 3;
            this.SavelogBtn2.Text = "Save Log";
            this.SavelogBtn2.UseVisualStyleBackColor = false;
            this.SavelogBtn2.Click += new System.EventHandler(this.SavelogBtn2_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(213)))), ((int)(((byte)(129)))));
            this.panel6.Controls.Add(this.Connect2);
            this.panel6.Controls.Add(this.Autoscroll2);
            this.panel6.Controls.Add(this.newlineChbox2);
            this.panel6.Controls.Add(this.refreshBtn2);
            this.panel6.Controls.Add(this.buadrate2);
            this.panel6.Controls.Add(this.type2);
            this.panel6.Controls.Add(this.Port2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(65, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(337, 99);
            this.panel6.TabIndex = 6;
            // 
            // Connect2
            // 
            this.Connect2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Connect2.FlatAppearance.BorderSize = 0;
            this.Connect2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connect2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Connect2.Location = new System.Drawing.Point(246, 13);
            this.Connect2.Name = "Connect2";
            this.Connect2.Size = new System.Drawing.Size(72, 29);
            this.Connect2.TabIndex = 2;
            this.Connect2.Text = "Connect";
            this.Connect2.UseVisualStyleBackColor = false;
            this.Connect2.Click += new System.EventHandler(this.Connect2_Click);
            // 
            // Autoscroll2
            // 
            this.Autoscroll2.AutoSize = true;
            this.Autoscroll2.Location = new System.Drawing.Point(99, 48);
            this.Autoscroll2.Name = "Autoscroll2";
            this.Autoscroll2.Size = new System.Drawing.Size(77, 17);
            this.Autoscroll2.TabIndex = 7;
            this.Autoscroll2.Text = "Auto Scroll";
            this.Autoscroll2.UseVisualStyleBackColor = true;
            this.Autoscroll2.CheckStateChanged += new System.EventHandler(this.Autoscroll2_CheckStateChanged);
            // 
            // newlineChbox2
            // 
            this.newlineChbox2.AutoSize = true;
            this.newlineChbox2.Location = new System.Drawing.Point(99, 64);
            this.newlineChbox2.Name = "newlineChbox2";
            this.newlineChbox2.Size = new System.Drawing.Size(71, 17);
            this.newlineChbox2.TabIndex = 7;
            this.newlineChbox2.Text = "New Line";
            this.newlineChbox2.UseVisualStyleBackColor = true;
            this.newlineChbox2.CheckStateChanged += new System.EventHandler(this.newlineChbox2_CheckStateChanged);
            // 
            // refreshBtn2
            // 
            this.refreshBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(30)))));
            this.refreshBtn2.FlatAppearance.BorderSize = 0;
            this.refreshBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.refreshBtn2.Location = new System.Drawing.Point(95, 13);
            this.refreshBtn2.Name = "refreshBtn2";
            this.refreshBtn2.Size = new System.Drawing.Size(62, 29);
            this.refreshBtn2.TabIndex = 9;
            this.refreshBtn2.Text = "Refresh";
            this.refreshBtn2.UseVisualStyleBackColor = false;
            this.refreshBtn2.Click += new System.EventHandler(this.refreshBtn2_Click);
            // 
            // buadrate2
            // 
            this.buadrate2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.buadrate2.FormattingEnabled = true;
            this.buadrate2.Items.AddRange(new object[] {
            "110",
            "600",
            "2400",
            "9600",
            "19200",
            "38400",
            "57600",
            "128000",
            "230400",
            "460800"});
            this.buadrate2.Location = new System.Drawing.Point(162, 13);
            this.buadrate2.Name = "buadrate2";
            this.buadrate2.Size = new System.Drawing.Size(83, 29);
            this.buadrate2.TabIndex = 6;
            // 
            // type2
            // 
            this.type2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.type2.FormattingEnabled = true;
            this.type2.Items.AddRange(new object[] {
            "Normal",
            "Dec",
            "HEX"});
            this.type2.Location = new System.Drawing.Point(10, 48);
            this.type2.Name = "type2";
            this.type2.Size = new System.Drawing.Size(83, 29);
            this.type2.TabIndex = 8;
            // 
            // Port2
            // 
            this.Port2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.Port2.FormattingEnabled = true;
            this.Port2.Location = new System.Drawing.Point(10, 13);
            this.Port2.Name = "Port2";
            this.Port2.Size = new System.Drawing.Size(84, 29);
            this.Port2.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(213)))), ((int)(((byte)(129)))));
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.statusSerial2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(65, 99);
            this.panel5.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // statusSerial2
            // 
            this.statusSerial2.BackgroundImage = global::Serial_Logger_Two_Port.Resource1.discon;
            this.statusSerial2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusSerial2.InitialImage = null;
            this.statusSerial2.Location = new System.Drawing.Point(15, 40);
            this.statusSerial2.Name = "statusSerial2";
            this.statusSerial2.Size = new System.Drawing.Size(41, 41);
            this.statusSerial2.TabIndex = 3;
            this.statusSerial2.TabStop = false;
            this.statusSerial2.UseWaitCursor = true;
            this.statusSerial2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.68622F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.78592F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.52786F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel4.Controls.Add(this.clear1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.inputSerial1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.typeS1, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 393);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(400, 28);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // clear1
            // 
            this.clear1.Location = new System.Drawing.Point(3, 3);
            this.clear1.Name = "clear1";
            this.clear1.Size = new System.Drawing.Size(80, 22);
            this.clear1.TabIndex = 17;
            this.clear1.Text = "Clear Monitor";
            this.clear1.UseVisualStyleBackColor = true;
            this.clear1.Click += new System.EventHandler(this.clear1_Click);
            // 
            // inputSerial1
            // 
            this.inputSerial1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputSerial1.Location = new System.Drawing.Point(89, 3);
            this.inputSerial1.Name = "inputSerial1";
            this.inputSerial1.Size = new System.Drawing.Size(166, 20);
            this.inputSerial1.TabIndex = 16;
            this.inputSerial1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputSerial1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 22);
            this.button1.TabIndex = 18;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // typeS1
            // 
            this.typeS1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeS1.FormattingEnabled = true;
            this.typeS1.Items.AddRange(new object[] {
            "No New Line",
            "New Line",
            "Carriage Return",
            "Both NL & CR"});
            this.typeS1.Location = new System.Drawing.Point(261, 3);
            this.typeS1.Name = "typeS1";
            this.typeS1.Size = new System.Drawing.Size(60, 21);
            this.typeS1.TabIndex = 19;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.94752F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.64431F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.52786F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel5.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.inputSerial2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.button3, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.typeS2, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(577, 393);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(402, 28);
            this.tableLayoutPanel5.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 22);
            this.button2.TabIndex = 17;
            this.button2.Text = "Clear Monitor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // inputSerial2
            // 
            this.inputSerial2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputSerial2.Location = new System.Drawing.Point(88, 3);
            this.inputSerial2.Name = "inputSerial2";
            this.inputSerial2.Size = new System.Drawing.Size(170, 20);
            this.inputSerial2.TabIndex = 16;
            this.inputSerial2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputSerial2_KeyDown);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 22);
            this.button3.TabIndex = 18;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.sendP2);
            // 
            // typeS2
            // 
            this.typeS2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeS2.FormattingEnabled = true;
            this.typeS2.Items.AddRange(new object[] {
            "No New Line",
            "New Line",
            "Carriage Return",
            "Both NL & CR"});
            this.typeS2.Location = new System.Drawing.Point(264, 3);
            this.typeS2.Name = "typeS2";
            this.typeS2.Size = new System.Drawing.Size(61, 21);
            this.typeS2.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(982, 448);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Serial Logger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusSerial1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusSerial2)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RichTextBox Display1;
        private System.Windows.Forms.Button Connect1;
        private System.Windows.Forms.PictureBox statusSerial1;
        private System.Windows.Forms.PictureBox statusSerial2;
        private System.Windows.Forms.RichTextBox Timelog1;
        private System.Windows.Forms.ComboBox buadrate1;
        private System.Windows.Forms.CheckBox newlineChbox1;
        private System.Windows.Forms.ComboBox type1;
        private System.Windows.Forms.ComboBox Port1;
        private System.Windows.Forms.RichTextBox Timelog2;
        private System.Windows.Forms.Button refreshBtn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox Autoscroll1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button SavelogBtn1;
        private System.Windows.Forms.SaveFileDialog SaveLog1;
        private System.Windows.Forms.CheckBox saveTime1;
        private System.Windows.Forms.LinkLabel LocationLink1;
        private System.Windows.Forms.Button StopSave1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Connect2;
        private System.Windows.Forms.CheckBox Autoscroll2;
        private System.Windows.Forms.CheckBox newlineChbox2;
        private System.Windows.Forms.Button refreshBtn2;
        private System.Windows.Forms.ComboBox buadrate2;
        private System.Windows.Forms.ComboBox type2;
        private System.Windows.Forms.ComboBox Port2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button StopSave2;
        private System.Windows.Forms.LinkLabel LocationLink2;
        private System.Windows.Forms.CheckBox saveTime2;
        private System.Windows.Forms.Button SavelogBtn2;
        private System.Windows.Forms.RichTextBox Display2;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.SaveFileDialog SaveLog2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox inputSerial1;
        private System.Windows.Forms.Button clear1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox typeS1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inputSerial2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox typeS2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

