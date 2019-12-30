using System.IO;

namespace QO_100_WB_Live_Tune
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
            this.mt_ip = new System.Windows.Forms.TextBox();
            this.mt_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lnb_offset = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.spectrum = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_DVBMode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_22KHz = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_lnbvolts = new System.Windows.Forms.ComboBox();
            this.comboBox_rxsocket = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.RxList = new System.Windows.Forms.ListView();
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RxSocket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LNBvolts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LNB22KHz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectrum)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mt_ip
            // 
            this.mt_ip.Location = new System.Drawing.Point(72, 23);
            this.mt_ip.Name = "mt_ip";
            this.mt_ip.Size = new System.Drawing.Size(66, 20);
            this.mt_ip.TabIndex = 2;
            this.mt_ip.Text = "232.0.0.11";
            // 
            // mt_port
            // 
            this.mt_port.Location = new System.Drawing.Point(72, 52);
            this.mt_port.Name = "mt_port";
            this.mt_port.Size = new System.Drawing.Size(66, 20);
            this.mt_port.TabIndex = 3;
            this.mt_port.Text = "6789";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "LNB Offset";
            // 
            // lnb_offset
            // 
            this.lnb_offset.Location = new System.Drawing.Point(72, 78);
            this.lnb_offset.Name = "lnb_offset";
            this.lnb_offset.Size = new System.Drawing.Size(66, 20);
            this.lnb_offset.TabIndex = 6;
            this.lnb_offset.Text = "9750000";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(940, 335);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.spectrum);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(932, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Display";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // spectrum
            // 
            this.spectrum.BackColor = System.Drawing.Color.Black;
            this.spectrum.Location = new System.Drawing.Point(6, 35);
            this.spectrum.Name = "spectrum";
            this.spectrum.Size = new System.Drawing.Size(922, 270);
            this.spectrum.TabIndex = 2;
            this.spectrum.TabStop = false;
            this.spectrum.Click += new System.EventHandler(this.spectrum_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(932, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 52);
            this.label4.TabIndex = 1;
            this.label4.Text = "You can add multiple Minitioune Receiver UDP settings.\r\nClick on each \'band\' of t" +
    "he spectrum to control each receiver.\r\nThe numbers on the left correspond to the" +
    " receiver.\r\nV0.8b 30/12/2019";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.RxList);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(909, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receiver List - UDP Control";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBox_DVBMode);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBox_22KHz);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox_lnbvolts);
            this.groupBox2.Controls.Add(this.comboBox_rxsocket);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.mt_ip);
            this.groupBox2.Controls.Add(this.lnb_offset);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mt_port);
            this.groupBox2.Location = new System.Drawing.Point(588, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 174);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setup a New Receiver:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "DVB Mode";
            // 
            // comboBox_DVBMode
            // 
            this.comboBox_DVBMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DVBMode.FormattingEnabled = true;
            this.comboBox_DVBMode.Items.AddRange(new object[] {
            "Auto",
            "DVB-S",
            "DVB-S2"});
            this.comboBox_DVBMode.Location = new System.Drawing.Point(224, 105);
            this.comboBox_DVBMode.MaxDropDownItems = 3;
            this.comboBox_DVBMode.Name = "comboBox_DVBMode";
            this.comboBox_DVBMode.Size = new System.Drawing.Size(66, 21);
            this.comboBox_DVBMode.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "LNB 22KHz";
            // 
            // comboBox_22KHz
            // 
            this.comboBox_22KHz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_22KHz.FormattingEnabled = true;
            this.comboBox_22KHz.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.comboBox_22KHz.Location = new System.Drawing.Point(224, 78);
            this.comboBox_22KHz.MaxDropDownItems = 3;
            this.comboBox_22KHz.Name = "comboBox_22KHz";
            this.comboBox_22KHz.Size = new System.Drawing.Size(66, 21);
            this.comboBox_22KHz.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "LNB Volts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rx Socket";
            // 
            // comboBox_lnbvolts
            // 
            this.comboBox_lnbvolts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_lnbvolts.FormattingEnabled = true;
            this.comboBox_lnbvolts.Items.AddRange(new object[] {
            "0",
            "13",
            "18"});
            this.comboBox_lnbvolts.Location = new System.Drawing.Point(224, 50);
            this.comboBox_lnbvolts.MaxDropDownItems = 3;
            this.comboBox_lnbvolts.Name = "comboBox_lnbvolts";
            this.comboBox_lnbvolts.Size = new System.Drawing.Size(66, 21);
            this.comboBox_lnbvolts.TabIndex = 11;
            // 
            // comboBox_rxsocket
            // 
            this.comboBox_rxsocket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rxsocket.FormattingEnabled = true;
            this.comboBox_rxsocket.Items.AddRange(new object[] {
            "A",
            "B"});
            this.comboBox_rxsocket.Location = new System.Drawing.Point(224, 23);
            this.comboBox_rxsocket.MaxDropDownItems = 2;
            this.comboBox_rxsocket.Name = "comboBox_rxsocket";
            this.comboBox_rxsocket.Size = new System.Drawing.Size(66, 21);
            this.comboBox_rxsocket.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add New Receiver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 139);
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
            this.Mode});
            this.RxList.FullRowSelect = true;
            this.RxList.HideSelection = false;
            this.RxList.Location = new System.Drawing.Point(18, 22);
            this.RxList.MultiSelect = false;
            this.RxList.Name = "RxList";
            this.RxList.Size = new System.Drawing.Size(536, 111);
            this.RxList.TabIndex = 9;
            this.RxList.UseCompatibleStateImageBehavior = false;
            this.RxList.View = System.Windows.Forms.View.Details;
            this.RxList.DoubleClick += new System.EventHandler(this.RxList_DoubleClick);
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 100;
            // 
            // Port
            // 
            this.Port.Text = "Port";
            // 
            // LO
            // 
            this.LO.Text = "LO";
            this.LO.Width = 100;
            // 
            // RxSocket
            // 
            this.RxSocket.Text = "Rx Socket";
            this.RxSocket.Width = 70;
            // 
            // LNBvolts
            // 
            this.LNBvolts.Text = "LNB Voltage";
            this.LNBvolts.Width = 80;
            // 
            // LNB22KHz
            // 
            this.LNB22KHz.Text = "22KHz";
            // 
            // Mode
            // 
            this.Mode.Text = "Mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 341);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "QO-100 WB Multi Quick Tune 0.8b ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spectrum)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox mt_ip;
        private System.Windows.Forms.TextBox mt_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lnb_offset;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView RxList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Port;
        private System.Windows.Forms.ColumnHeader LO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_lnbvolts;
        private System.Windows.Forms.ComboBox comboBox_rxsocket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader RxSocket;
        private System.Windows.Forms.ColumnHeader LNBvolts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_DVBMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_22KHz;
        private System.Windows.Forms.ColumnHeader LNB22KHz;
        private System.Windows.Forms.ColumnHeader Mode;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox spectrum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

