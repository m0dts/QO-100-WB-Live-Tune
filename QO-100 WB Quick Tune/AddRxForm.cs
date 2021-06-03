using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QO_100_WB_Quick_Tune
{
    public partial class AddRxForm : Form
    {
        private Label label1;

        public AddRxForm()
        {
            InitializeComponent();
            Load += new EventHandler(AddRxForm_Load);
            mt_22KHz.SelectedIndex = 0;
            mt_DVBMode.SelectedIndex = 0;
            mt_lnbvolts.SelectedIndex = 0;
            mt_lowsr.SelectedIndex = 0;
            mt_rxsocket.SelectedIndex = 0;
            mt_widescan.SelectedIndex = 0;
            wh_22KHz.SelectedIndex = 0;
            wh_lnbvolts.SelectedIndex = 0;
            wh_rxsocket.SelectedIndex = 0;
        }

        private void AddRxForm_Load(object sender, EventArgs e)
        {
           
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Minitioune = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.mt_ip = new System.Windows.Forms.TextBox();
            this.mt_lnb_offset = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mt_port = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mt_lowsr = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mt_widescan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mt_DVBMode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mt_22KHz = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mt_lnbvolts = new System.Windows.Forms.ComboBox();
            this.mt_rxsocket = new System.Windows.Forms.ComboBox();
            this.Ryde = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.ryde_add = new System.Windows.Forms.Button();
            this.ryde_band = new System.Windows.Forms.ComboBox();
            this.ryde_label_band = new System.Windows.Forms.Label();
            this.ryde_ip = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ryde_port = new System.Windows.Forms.TextBox();
            this.WInterHill = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.wh_ip = new System.Windows.Forms.TextBox();
            this.wh_lnb_offset = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.wh_port = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.wh_22KHz = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.wh_lnbvolts = new System.Windows.Forms.ComboBox();
            this.wh_rxsocket = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.Minitioune.SuspendLayout();
            this.Ryde.SuspendLayout();
            this.WInterHill.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Receiver:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.WInterHill);
            this.tabControl1.Controls.Add(this.Ryde);
            this.tabControl1.Controls.Add(this.Minitioune);
            this.tabControl1.Location = new System.Drawing.Point(12, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(183, 311);
            this.tabControl1.TabIndex = 40;
            // 
            // Minitioune
            // 
            this.Minitioune.Controls.Add(this.button2);
            this.Minitioune.Controls.Add(this.mt_ip);
            this.Minitioune.Controls.Add(this.mt_lnb_offset);
            this.Minitioune.Controls.Add(this.label2);
            this.Minitioune.Controls.Add(this.label3);
            this.Minitioune.Controls.Add(this.label4);
            this.Minitioune.Controls.Add(this.mt_port);
            this.Minitioune.Controls.Add(this.label11);
            this.Minitioune.Controls.Add(this.mt_lowsr);
            this.Minitioune.Controls.Add(this.label10);
            this.Minitioune.Controls.Add(this.mt_widescan);
            this.Minitioune.Controls.Add(this.label8);
            this.Minitioune.Controls.Add(this.mt_DVBMode);
            this.Minitioune.Controls.Add(this.label7);
            this.Minitioune.Controls.Add(this.mt_22KHz);
            this.Minitioune.Controls.Add(this.label6);
            this.Minitioune.Controls.Add(this.label5);
            this.Minitioune.Controls.Add(this.mt_lnbvolts);
            this.Minitioune.Controls.Add(this.mt_rxsocket);
            this.Minitioune.Location = new System.Drawing.Point(4, 22);
            this.Minitioune.Name = "Minitioune";
            this.Minitioune.Padding = new System.Windows.Forms.Padding(3);
            this.Minitioune.Size = new System.Drawing.Size(175, 285);
            this.Minitioune.TabIndex = 0;
            this.Minitioune.Text = "Minitioune";
            this.Minitioune.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 23);
            this.button2.TabIndex = 72;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mt_ip
            // 
            this.mt_ip.Location = new System.Drawing.Point(69, 6);
            this.mt_ip.Name = "mt_ip";
            this.mt_ip.Size = new System.Drawing.Size(91, 20);
            this.mt_ip.TabIndex = 52;
            this.mt_ip.Text = "232.0.0.11";
            this.mt_ip.TextChanged += new System.EventHandler(this.mt_ip_TextChanged);
            // 
            // mt_lnb_offset
            // 
            this.mt_lnb_offset.Location = new System.Drawing.Point(69, 61);
            this.mt_lnb_offset.Name = "mt_lnb_offset";
            this.mt_lnb_offset.Size = new System.Drawing.Size(66, 20);
            this.mt_lnb_offset.TabIndex = 56;
            this.mt_lnb_offset.Text = "9750000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "IP Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "LNB Offset";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Port";
            // 
            // mt_port
            // 
            this.mt_port.Location = new System.Drawing.Point(69, 35);
            this.mt_port.Name = "mt_port";
            this.mt_port.Size = new System.Drawing.Size(39, 20);
            this.mt_port.TabIndex = 53;
            this.mt_port.Text = "6789";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "LowSR";
            // 
            // mt_lowsr
            // 
            this.mt_lowsr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mt_lowsr.FormattingEnabled = true;
            this.mt_lowsr.Items.AddRange(new object[] {
            "0",
            "1"});
            this.mt_lowsr.Location = new System.Drawing.Point(69, 223);
            this.mt_lowsr.MaxDropDownItems = 3;
            this.mt_lowsr.Name = "mt_lowsr";
            this.mt_lowsr.Size = new System.Drawing.Size(66, 21);
            this.mt_lowsr.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "WideScan";
            // 
            // mt_widescan
            // 
            this.mt_widescan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mt_widescan.FormattingEnabled = true;
            this.mt_widescan.Items.AddRange(new object[] {
            "0",
            "1"});
            this.mt_widescan.Location = new System.Drawing.Point(69, 196);
            this.mt_widescan.MaxDropDownItems = 3;
            this.mt_widescan.Name = "mt_widescan";
            this.mt_widescan.Size = new System.Drawing.Size(66, 21);
            this.mt_widescan.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "DVB Mode";
            // 
            // mt_DVBMode
            // 
            this.mt_DVBMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mt_DVBMode.FormattingEnabled = true;
            this.mt_DVBMode.Items.AddRange(new object[] {
            "Auto",
            "DVB-S",
            "DVB-S2"});
            this.mt_DVBMode.Location = new System.Drawing.Point(69, 169);
            this.mt_DVBMode.MaxDropDownItems = 3;
            this.mt_DVBMode.Name = "mt_DVBMode";
            this.mt_DVBMode.Size = new System.Drawing.Size(66, 21);
            this.mt_DVBMode.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "LNB 22KHz";
            // 
            // mt_22KHz
            // 
            this.mt_22KHz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mt_22KHz.FormattingEnabled = true;
            this.mt_22KHz.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.mt_22KHz.Location = new System.Drawing.Point(69, 142);
            this.mt_22KHz.MaxDropDownItems = 3;
            this.mt_22KHz.Name = "mt_22KHz";
            this.mt_22KHz.Size = new System.Drawing.Size(66, 21);
            this.mt_22KHz.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "LNB Volts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Rx Socket";
            // 
            // mt_lnbvolts
            // 
            this.mt_lnbvolts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mt_lnbvolts.FormattingEnabled = true;
            this.mt_lnbvolts.Items.AddRange(new object[] {
            "0",
            "13",
            "18"});
            this.mt_lnbvolts.Location = new System.Drawing.Point(69, 114);
            this.mt_lnbvolts.MaxDropDownItems = 3;
            this.mt_lnbvolts.Name = "mt_lnbvolts";
            this.mt_lnbvolts.Size = new System.Drawing.Size(66, 21);
            this.mt_lnbvolts.TabIndex = 41;
            // 
            // mt_rxsocket
            // 
            this.mt_rxsocket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mt_rxsocket.FormattingEnabled = true;
            this.mt_rxsocket.Items.AddRange(new object[] {
            "A",
            "B"});
            this.mt_rxsocket.Location = new System.Drawing.Point(69, 87);
            this.mt_rxsocket.MaxDropDownItems = 2;
            this.mt_rxsocket.Name = "mt_rxsocket";
            this.mt_rxsocket.Size = new System.Drawing.Size(66, 21);
            this.mt_rxsocket.TabIndex = 40;
            // 
            // Ryde
            // 
            this.Ryde.Controls.Add(this.label15);
            this.Ryde.Controls.Add(this.ryde_add);
            this.Ryde.Controls.Add(this.ryde_band);
            this.Ryde.Controls.Add(this.ryde_label_band);
            this.Ryde.Controls.Add(this.ryde_ip);
            this.Ryde.Controls.Add(this.label9);
            this.Ryde.Controls.Add(this.label13);
            this.Ryde.Controls.Add(this.ryde_port);
            this.Ryde.Location = new System.Drawing.Point(4, 22);
            this.Ryde.Name = "Ryde";
            this.Ryde.Padding = new System.Windows.Forms.Padding(3);
            this.Ryde.Size = new System.Drawing.Size(175, 285);
            this.Ryde.TabIndex = 1;
            this.Ryde.Text = "Ryde";
            this.Ryde.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 78);
            this.label15.TabIndex = 72;
            this.label15.Text = "Specify IP and Port of Ryde \r\nReceiver.\r\nClick the select band dropdown, \r\nit wil" +
    "l be populated if the Ryde\r\nresponds.\r\nChoose QO-100 then press Add.";
            // 
            // ryde_add
            // 
            this.ryde_add.Enabled = false;
            this.ryde_add.Location = new System.Drawing.Point(3, 259);
            this.ryde_add.Name = "ryde_add";
            this.ryde_add.Size = new System.Drawing.Size(169, 23);
            this.ryde_add.TabIndex = 71;
            this.ryde_add.Text = "Add";
            this.ryde_add.UseVisualStyleBackColor = true;
            this.ryde_add.Click += new System.EventHandler(this.ryde_add_Click);
            // 
            // ryde_band
            // 
            this.ryde_band.FormattingEnabled = true;
            this.ryde_band.Location = new System.Drawing.Point(70, 74);
            this.ryde_band.MaxDropDownItems = 2;
            this.ryde_band.Name = "ryde_band";
            this.ryde_band.Size = new System.Drawing.Size(91, 21);
            this.ryde_band.TabIndex = 70;
            this.ryde_band.Text = "Click Here";
            this.ryde_band.SelectedIndexChanged += new System.EventHandler(this.ryde_band_SelectedIndexChanged);
            this.ryde_band.Click += new System.EventHandler(this.ryde_band_Click);
            // 
            // ryde_label_band
            // 
            this.ryde_label_band.AutoSize = true;
            this.ryde_label_band.Location = new System.Drawing.Point(5, 77);
            this.ryde_label_band.Name = "ryde_label_band";
            this.ryde_label_band.Size = new System.Drawing.Size(65, 13);
            this.ryde_label_band.TabIndex = 69;
            this.ryde_label_band.Text = "Select Band";
            // 
            // ryde_ip
            // 
            this.ryde_ip.Location = new System.Drawing.Point(70, 19);
            this.ryde_ip.Name = "ryde_ip";
            this.ryde_ip.Size = new System.Drawing.Size(91, 20);
            this.ryde_ip.TabIndex = 62;
            this.ryde_ip.Text = "192.168.1.43";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "IP Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "Port";
            // 
            // ryde_port
            // 
            this.ryde_port.Location = new System.Drawing.Point(70, 48);
            this.ryde_port.Name = "ryde_port";
            this.ryde_port.Size = new System.Drawing.Size(39, 20);
            this.ryde_port.TabIndex = 63;
            this.ryde_port.Text = "8765";
            // 
            // WInterHill
            // 
            this.WInterHill.Controls.Add(this.button1);
            this.WInterHill.Controls.Add(this.wh_ip);
            this.WInterHill.Controls.Add(this.wh_lnb_offset);
            this.WInterHill.Controls.Add(this.label12);
            this.WInterHill.Controls.Add(this.label14);
            this.WInterHill.Controls.Add(this.label16);
            this.WInterHill.Controls.Add(this.wh_port);
            this.WInterHill.Controls.Add(this.label20);
            this.WInterHill.Controls.Add(this.wh_22KHz);
            this.WInterHill.Controls.Add(this.label21);
            this.WInterHill.Controls.Add(this.label22);
            this.WInterHill.Controls.Add(this.wh_lnbvolts);
            this.WInterHill.Controls.Add(this.wh_rxsocket);
            this.WInterHill.Location = new System.Drawing.Point(4, 22);
            this.WInterHill.Name = "WInterHill";
            this.WInterHill.Padding = new System.Windows.Forms.Padding(3);
            this.WInterHill.Size = new System.Drawing.Size(175, 285);
            this.WInterHill.TabIndex = 2;
            this.WInterHill.Text = "WinterHill";
            this.WInterHill.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 91;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wh_ip
            // 
            this.wh_ip.Location = new System.Drawing.Point(69, 6);
            this.wh_ip.Name = "wh_ip";
            this.wh_ip.Size = new System.Drawing.Size(91, 20);
            this.wh_ip.TabIndex = 85;
            this.wh_ip.Text = "192.168.1.45";
            // 
            // wh_lnb_offset
            // 
            this.wh_lnb_offset.Location = new System.Drawing.Point(69, 61);
            this.wh_lnb_offset.Name = "wh_lnb_offset";
            this.wh_lnb_offset.Size = new System.Drawing.Size(66, 20);
            this.wh_lnb_offset.TabIndex = 89;
            this.wh_lnb_offset.Text = "9750000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 87;
            this.label12.Text = "IP Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 90;
            this.label14.Text = "LNB Offset";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 88;
            this.label16.Text = "Port";
            // 
            // wh_port
            // 
            this.wh_port.Location = new System.Drawing.Point(69, 35);
            this.wh_port.Name = "wh_port";
            this.wh_port.Size = new System.Drawing.Size(39, 20);
            this.wh_port.TabIndex = 86;
            this.wh_port.Text = "9921";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 145);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 13);
            this.label20.TabIndex = 78;
            this.label20.Text = "LNB 22KHz";
            // 
            // wh_22KHz
            // 
            this.wh_22KHz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wh_22KHz.FormattingEnabled = true;
            this.wh_22KHz.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.wh_22KHz.Location = new System.Drawing.Point(69, 142);
            this.wh_22KHz.MaxDropDownItems = 3;
            this.wh_22KHz.Name = "wh_22KHz";
            this.wh_22KHz.Size = new System.Drawing.Size(66, 21);
            this.wh_22KHz.TabIndex = 77;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 117);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 13);
            this.label21.TabIndex = 76;
            this.label21.Text = "LNB Volts";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 90);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 13);
            this.label22.TabIndex = 75;
            this.label22.Text = "Rx Socket";
            // 
            // wh_lnbvolts
            // 
            this.wh_lnbvolts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wh_lnbvolts.FormattingEnabled = true;
            this.wh_lnbvolts.Items.AddRange(new object[] {
            "0",
            "13",
            "18"});
            this.wh_lnbvolts.Location = new System.Drawing.Point(69, 114);
            this.wh_lnbvolts.MaxDropDownItems = 3;
            this.wh_lnbvolts.Name = "wh_lnbvolts";
            this.wh_lnbvolts.Size = new System.Drawing.Size(66, 21);
            this.wh_lnbvolts.TabIndex = 74;
            // 
            // wh_rxsocket
            // 
            this.wh_rxsocket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wh_rxsocket.FormattingEnabled = true;
            this.wh_rxsocket.Items.AddRange(new object[] {
            "A",
            "B"});
            this.wh_rxsocket.Location = new System.Drawing.Point(69, 87);
            this.wh_rxsocket.MaxDropDownItems = 2;
            this.wh_rxsocket.Name = "wh_rxsocket";
            this.wh_rxsocket.Size = new System.Drawing.Size(66, 21);
            this.wh_rxsocket.TabIndex = 73;
            // 
            // AddRxForm
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(205, 351);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddRxForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tabControl1.ResumeLayout(false);
            this.Minitioune.ResumeLayout(false);
            this.Minitioune.PerformLayout();
            this.Ryde.ResumeLayout(false);
            this.Ryde.PerformLayout();
            this.WInterHill.ResumeLayout(false);
            this.WInterHill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private TabControl tabControl1;
        private TabPage Minitioune;
        private TextBox mt_ip;
        private TextBox mt_lnb_offset;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox mt_port;
        private Label label11;
        private ComboBox mt_lowsr;
        private Label label10;
        private ComboBox mt_widescan;
        private Label label8;
        private ComboBox mt_DVBMode;
        private Label label7;
        private ComboBox mt_22KHz;
        private Label label6;
        private Label label5;
        private ComboBox mt_lnbvolts;
        private ComboBox mt_rxsocket;
        private TabPage Ryde;
        private ComboBox ryde_band;
        private Label ryde_label_band;
        private TextBox ryde_ip;
        private Label label9;
        private Label label13;
        private TextBox ryde_port;
        private Button ryde_add;
        private Button button2;
        private Label label15;

        public string ip;
        public int port;
        public string rydeband;
        public int lo;
        public string rxsocket;
        public string lnbvolts;
        public string lnb22khz;
        public string dvbmode;
        public string widescan;
        public string lowsr;
        private TabPage WInterHill;
        private Button button1;
        private TextBox wh_ip;
        private TextBox wh_lnb_offset;
        private Label label12;
        private Label label14;
        private Label label16;
        private TextBox wh_port;
        private Label label20;
        private ComboBox wh_22KHz;
        private Label label21;
        private Label label22;
        private ComboBox wh_lnbvolts;
        private ComboBox wh_rxsocket;
        public string rx_added;

        public string get_rx_added()
        {
            return rx_added;
        }
        public string get_ip()
        {
            return ip;
        }
        public int get_port()
        {
            return port;
        }
        public string get_rydeband()
        {
            return rydeband;
        }
        public int get_lo()
        {
            return lo;
        }
        public string get_rxsocket()
        {
            return rxsocket;
        }
        public string get_lnbvolts()
        {
            return lnbvolts;
        }
        public string get_lnb22khz()
        {
            return lnb22khz;
        }
        public string get_dvbmode()
        {
            return dvbmode;
        }
        public string get_widescan()
        {
            return widescan;
        }
        public string get_lowsr()
        {
            return lowsr;
        }

        private void ryde_band_Click(object sender, EventArgs e)
        {
            ryde_band.Items.Clear();

            TcpClient tcpclnt = new TcpClient();
            int len = 0;
            bool err = false;
            byte[] reply_array = new byte[1024];

            if (Convert.ToInt16(ryde_ip.Text.Split('.')[0]) < 210)        //IP start above 209 not allowed
            {
                IPAddress ip = IPAddress.Parse(ryde_ip.Text);
                int port = Convert.ToInt32(ryde_port.Text);
                
                if (tcpclnt.ConnectAsync(ip, port).Wait(TimeSpan.FromSeconds(1)))
                {
                    Stream stm = tcpclnt.GetStream();
                    stm.ReadTimeout = 2000;
                    stm.WriteTimeout = 2000;

                    JObject jobj = JObject.Parse("{'request':'getBands'}");
                    string json = JsonConvert.SerializeObject(jobj);
                    byte[] outStream2 = Encoding.UTF8.GetBytes(json);

                    try
                    {
                        stm.Write(outStream2, 0, outStream2.Length);
                        len = stm.Read(reply_array, 0, 1024);
                    }
                    catch
                    {
                        err = true;
                    }
                    tcpclnt.Close();
                }
                else
                {
                    err = true;
                }
            }
            else
            {
                err = true;
            }


            if (!err)
            {
                ryde_band.Items.Clear();
                ryde_band.ForeColor = System.Drawing.Color.Black;
                ryde_add.Enabled = true;
                ryde_band.Text = "";
                ryde_band.Refresh();
                var array = JObject.Parse(System.Text.Encoding.UTF8.GetString(reply_array, 0, len));
                foreach (KeyValuePair<string, JToken> band in (JObject)array["bands"])
                {
                    ryde_band.Items.Add(band.Key);
                }
            }
            else
            {
                ryde_band.Items.Add("Connect Error!");
                ryde_band.SelectedIndex = 0;
                ryde_band.ForeColor = System.Drawing.Color.Red;
                ryde_label_band.Select();
                ryde_add.Enabled = false;
            }


        }

        private void ryde_band_SelectedIndexChanged(object sender, EventArgs e)
        {
            ryde_label_band.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IPAddress address;
            int _port;
            int _lo;
            if (IPAddress.TryParse(mt_ip.Text, out address) & int.TryParse(mt_port.Text, out _port) & int.TryParse(mt_lnb_offset.Text, out _lo))
            {
                port = _port;
                lo = _lo;
                ip = address.ToString();
                rxsocket = mt_rxsocket.Text;
                lnbvolts = mt_lnbvolts.Text;
                dvbmode = mt_DVBMode.Text;
                lnb22khz = mt_22KHz.Text;
                widescan = mt_widescan.Text;
                lowsr = mt_lowsr.Text;
                rx_added = "Minitioune";
                this.Hide();
            }


        }

        private void ryde_add_Click(object sender, EventArgs e)
        {
            ip = ryde_ip.Text;
            port = Convert.ToInt16(ryde_port.Text);
            rydeband = ryde_band.Text;
            rx_added = "Ryde";
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rx_added = "WinterHill";
        }

        private void mt_ip_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                IPAddress address;
                int _port;
                int _lo;
                if (IPAddress.TryParse(wh_ip.Text, out address) & int.TryParse(wh_port.Text, out _port) & int.TryParse(wh_lnb_offset.Text, out _lo))
                {
                    port = _port;
                    lo = _lo;
                    ip = address.ToString();
                    rxsocket = mt_rxsocket.Text;
                    lnbvolts = mt_lnbvolts.Text;
                    dvbmode = "-";
                    lnb22khz = mt_22KHz.Text;
                    widescan = "-"; ;
                    lowsr = "-";
                    rx_added = "WinterHill";
                    this.Hide();
                }


            
        }
    }
}
