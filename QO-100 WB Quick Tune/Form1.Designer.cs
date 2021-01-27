using System.IO;

namespace QO_100_WB_Quick_Tune
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.error_label = new System.Windows.Forms.Label();
            this.combo_mode = new System.Windows.Forms.ComboBox();
            this.button_close = new System.Windows.Forms.Button();
            this.spectrum = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.wh_lo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.wh_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_wh_scan = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.wh_port = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_ontop = new System.Windows.Forms.CheckBox();
            this.checkBox_minimal = new System.Windows.Forms.CheckBox();
            this.trackBar_opacity = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.check_avoidbeacon = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_rxs_scan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_minsr = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.combo_WaitTime = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.RxList = new System.Windows.Forms.ListView();
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RxSocket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LNBvolts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LNB22KHz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wide = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LowSR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RxType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RydeBand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer_wh = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectrum)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_opacity)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 339);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.error_label);
            this.tabPage1.Controls.Add(this.combo_mode);
            this.tabPage1.Controls.Add(this.button_close);
            this.tabPage1.Controls.Add(this.spectrum);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(921, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Display";
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.BackColor = System.Drawing.Color.Black;
            this.error_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.error_label.Location = new System.Drawing.Point(327, 13);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 13);
            this.error_label.TabIndex = 5;
            // 
            // combo_mode
            // 
            this.combo_mode.Items.AddRange(new object[] {
            "Manual Tune",
            "Auto Tune (Hold)",
            "Auto Tune (Timed)"});
            this.combo_mode.Location = new System.Drawing.Point(8, 5);
            this.combo_mode.Name = "combo_mode";
            this.combo_mode.Size = new System.Drawing.Size(121, 21);
            this.combo_mode.TabIndex = 4;
            this.combo_mode.Text = "Manual Tune";
            this.combo_mode.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(875, 3);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(43, 23);
            this.button_close.TabIndex = 3;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // spectrum
            // 
            this.spectrum.BackColor = System.Drawing.Color.Black;
            this.spectrum.Cursor = System.Windows.Forms.Cursors.Cross;
            this.spectrum.Location = new System.Drawing.Point(-1, 36);
            this.spectrum.Margin = new System.Windows.Forms.Padding(0);
            this.spectrum.Name = "spectrum";
            this.spectrum.Size = new System.Drawing.Size(922, 275);
            this.spectrum.TabIndex = 2;
            this.spectrum.TabStop = false;
            this.spectrum.Click += new System.EventHandler(this.spectrum_Click);
            this.spectrum.MouseMove += new System.Windows.Forms.MouseEventHandler(this.spectrum_MouseMove);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(921, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.wh_lo);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.wh_ip);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.checkBox_wh_scan);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.wh_port);
            this.groupBox4.Location = new System.Drawing.Point(730, 174);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(183, 133);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "WinterHill";
            // 
            // wh_lo
            // 
            this.wh_lo.Location = new System.Drawing.Point(77, 64);
            this.wh_lo.Name = "wh_lo";
            this.wh_lo.Size = new System.Drawing.Size(66, 20);
            this.wh_lo.TabIndex = 60;
            this.wh_lo.Text = "9750000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "LNB Offset";
            // 
            // wh_ip
            // 
            this.wh_ip.Location = new System.Drawing.Point(77, 13);
            this.wh_ip.Name = "wh_ip";
            this.wh_ip.Size = new System.Drawing.Size(91, 20);
            this.wh_ip.TabIndex = 56;
            this.wh_ip.Text = "232.0.0.11";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "IP Address";
            // 
            // checkBox_wh_scan
            // 
            this.checkBox_wh_scan.AutoSize = true;
            this.checkBox_wh_scan.Location = new System.Drawing.Point(16, 100);
            this.checkBox_wh_scan.Name = "checkBox_wh_scan";
            this.checkBox_wh_scan.Size = new System.Drawing.Size(113, 17);
            this.checkBox_wh_scan.TabIndex = 0;
            this.checkBox_wh_scan.Text = "Enable Scan Data";
            this.checkBox_wh_scan.UseVisualStyleBackColor = true;
            this.checkBox_wh_scan.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Port";
            // 
            // wh_port
            // 
            this.wh_port.Location = new System.Drawing.Point(77, 38);
            this.wh_port.Name = "wh_port";
            this.wh_port.Size = new System.Drawing.Size(39, 20);
            this.wh_port.TabIndex = 57;
            this.wh_port.Text = "9910";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_ontop);
            this.groupBox2.Controls.Add(this.checkBox_minimal);
            this.groupBox2.Controls.Add(this.trackBar_opacity);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(6, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Settings";
            // 
            // checkBox_ontop
            // 
            this.checkBox_ontop.AutoSize = true;
            this.checkBox_ontop.Location = new System.Drawing.Point(6, 32);
            this.checkBox_ontop.Name = "checkBox_ontop";
            this.checkBox_ontop.Size = new System.Drawing.Size(96, 17);
            this.checkBox_ontop.TabIndex = 8;
            this.checkBox_ontop.Text = "Always on Top";
            this.checkBox_ontop.UseVisualStyleBackColor = true;
            this.checkBox_ontop.CheckedChanged += new System.EventHandler(this.checkBox_ontop_CheckedChanged);
            // 
            // checkBox_minimal
            // 
            this.checkBox_minimal.AutoSize = true;
            this.checkBox_minimal.Location = new System.Drawing.Point(6, 55);
            this.checkBox_minimal.Name = "checkBox_minimal";
            this.checkBox_minimal.Size = new System.Drawing.Size(61, 17);
            this.checkBox_minimal.TabIndex = 11;
            this.checkBox_minimal.Text = "Minimal";
            this.checkBox_minimal.UseVisualStyleBackColor = true;
            this.checkBox_minimal.CheckedChanged += new System.EventHandler(this.checkBox_minimal_CheckedChanged);
            // 
            // trackBar_opacity
            // 
            this.trackBar_opacity.AutoSize = false;
            this.trackBar_opacity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trackBar_opacity.Location = new System.Drawing.Point(149, 42);
            this.trackBar_opacity.Maximum = 100;
            this.trackBar_opacity.Minimum = 25;
            this.trackBar_opacity.Name = "trackBar_opacity";
            this.trackBar_opacity.Size = new System.Drawing.Size(175, 26);
            this.trackBar_opacity.TabIndex = 9;
            this.trackBar_opacity.TickFrequency = 10;
            this.trackBar_opacity.Value = 100;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Opacity";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.check_avoidbeacon);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.combo_rxs_scan);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.combo_minsr);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.combo_WaitTime);
            this.groupBox3.Location = new System.Drawing.Point(730, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 162);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auto Tune";
            // 
            // check_avoidbeacon
            // 
            this.check_avoidbeacon.AutoSize = true;
            this.check_avoidbeacon.Location = new System.Drawing.Point(6, 104);
            this.check_avoidbeacon.Name = "check_avoidbeacon";
            this.check_avoidbeacon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_avoidbeacon.Size = new System.Drawing.Size(93, 17);
            this.check_avoidbeacon.TabIndex = 6;
            this.check_avoidbeacon.Text = "Avoid Beacon";
            this.check_avoidbeacon.UseVisualStyleBackColor = true;
            this.check_avoidbeacon.CheckedChanged += new System.EventHandler(this.check_avoidbeacon_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "No. of Rx to scan";
            // 
            // combo_rxs_scan
            // 
            this.combo_rxs_scan.FormattingEnabled = true;
            this.combo_rxs_scan.Items.AddRange(new object[] {
            "1"});
            this.combo_rxs_scan.Location = new System.Drawing.Point(112, 73);
            this.combo_rxs_scan.Name = "combo_rxs_scan";
            this.combo_rxs_scan.Size = new System.Drawing.Size(56, 21);
            this.combo_rxs_scan.TabIndex = 4;
            this.combo_rxs_scan.Text = "0";
            this.combo_rxs_scan.SelectedIndexChanged += new System.EventHandler(this.combo_rxs_scan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Min SR to tune (KS)";
            // 
            // combo_minsr
            // 
            this.combo_minsr.FormattingEnabled = true;
            this.combo_minsr.Items.AddRange(new object[] {
            "25",
            "66",
            "125",
            "250",
            "333",
            "500",
            "1000"});
            this.combo_minsr.Location = new System.Drawing.Point(112, 46);
            this.combo_minsr.Name = "combo_minsr";
            this.combo_minsr.Size = new System.Drawing.Size(56, 21);
            this.combo_minsr.TabIndex = 2;
            this.combo_minsr.Text = "66";
            this.combo_minsr.SelectedIndexChanged += new System.EventHandler(this.combo_minsr_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Wait Time (minutes)";
            // 
            // combo_WaitTime
            // 
            this.combo_WaitTime.FormattingEnabled = true;
            this.combo_WaitTime.Items.AddRange(new object[] {
            "0.5",
            "1",
            "2",
            "5",
            "10"});
            this.combo_WaitTime.Location = new System.Drawing.Point(112, 19);
            this.combo_WaitTime.Name = "combo_WaitTime";
            this.combo_WaitTime.Size = new System.Drawing.Size(56, 21);
            this.combo_WaitTime.TabIndex = 0;
            this.combo_WaitTime.Text = "0.5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.RxList);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receiver List - UDP Control";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add Receiver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Remove Selected Row";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RxList
            // 
            this.RxList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address,
            this.Port,
            this.LO,
            this.RxSocket,
            this.LNBvolts,
            this.LNB22KHz,
            this.Mode,
            this.Wide,
            this.LowSR,
            this.RxType,
            this.RydeBand});
            this.RxList.FullRowSelect = true;
            this.RxList.HideSelection = false;
            this.RxList.Location = new System.Drawing.Point(6, 22);
            this.RxList.MultiSelect = false;
            this.RxList.Name = "RxList";
            this.RxList.Size = new System.Drawing.Size(703, 111);
            this.RxList.TabIndex = 9;
            this.RxList.UseCompatibleStateImageBehavior = false;
            this.RxList.View = System.Windows.Forms.View.Details;
            this.RxList.SelectedIndexChanged += new System.EventHandler(this.RxList_SelectedIndexChanged);
            this.RxList.DoubleClick += new System.EventHandler(this.RxList_DoubleClick);
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 80;
            // 
            // Port
            // 
            this.Port.Text = "Port";
            this.Port.Width = 50;
            // 
            // LO
            // 
            this.LO.Text = "LO";
            this.LO.Width = 55;
            // 
            // RxSocket
            // 
            this.RxSocket.Text = "F Plug";
            this.RxSocket.Width = 50;
            // 
            // LNBvolts
            // 
            this.LNBvolts.Text = "LNB Volt";
            this.LNBvolts.Width = 55;
            // 
            // LNB22KHz
            // 
            this.LNB22KHz.Text = "LNB22KHz";
            this.LNB22KHz.Width = 65;
            // 
            // Mode
            // 
            this.Mode.Text = "Mode";
            this.Mode.Width = 55;
            // 
            // Wide
            // 
            this.Wide.Text = "WideScan";
            this.Wide.Width = 65;
            // 
            // LowSR
            // 
            this.LowSR.Text = "LowSR";
            this.LowSR.Width = 50;
            // 
            // RxType
            // 
            this.RxType.Text = "Rx Type";
            this.RxType.Width = 80;
            // 
            // RydeBand
            // 
            this.RydeBand.Text = "Ryde Band";
            this.RydeBand.Width = 85;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(921, 313);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Info";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(499, 234);
            this.label4.TabIndex = 2;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer_wh
            // 
            this.timer_wh.Interval = 2000;
            this.timer_wh.Tick += new System.EventHandler(this.timer_wh_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 338);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "QO-100 WB Quick Tune 1.22b (Jan 2021) - @M0DTS";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectrum)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_opacity)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView RxList;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Port;
        private System.Windows.Forms.ColumnHeader LO;
        private System.Windows.Forms.ColumnHeader RxSocket;
        private System.Windows.Forms.ColumnHeader LNBvolts;
        private System.Windows.Forms.ColumnHeader LNB22KHz;
        private System.Windows.Forms.ColumnHeader Mode;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox spectrum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBar_opacity;
        private System.Windows.Forms.CheckBox checkBox_ontop;
        private System.Windows.Forms.CheckBox checkBox_minimal;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.ColumnHeader Wide;
        private System.Windows.Forms.ColumnHeader LowSR;
        private System.Windows.Forms.ColumnHeader RxType;
        private System.Windows.Forms.ComboBox combo_mode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox combo_WaitTime;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader RydeBand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_minsr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_rxs_scan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox_wh_scan;
        private System.Windows.Forms.TextBox wh_ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox wh_port;
        private System.Windows.Forms.Timer timer_wh;
        private System.Windows.Forms.TextBox wh_lo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox check_avoidbeacon;
        private System.Windows.Forms.Label error_label;
    }
}

