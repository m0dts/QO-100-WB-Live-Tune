using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QO_100_WB_Quick_Tune
{
    public partial class Form1 : Form
    {

        //github version info
        //https://api.github.com/repos/m0dts/QO-100-WB-Live-Tune/releases/latest

        private static readonly Object list_lock = new Object();
        // private WebSocket ws;       //websocket client

        static int width = 922;     //web monitor uses 922 points, 6 padded?
        static int height = 255;    //makes things easier
        static int bandplan_height = 30;

        static Bitmap bmp = new Bitmap(width, height + 20);
        static Bitmap bmp2 = new Bitmap(width, bandplan_height);     //bandplan
        Pen greenpen = new Pen(Color.FromArgb(200, 20, 200, 20));
        Pen greypen = new Pen(Color.Gray, width: 1) { DashPattern = new[] { 10f, 10f } };
        SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(128, Color.Gray));
        SolidBrush bandplanBrush = new SolidBrush(Color.FromArgb(180, 150, 150, 255));

        Graphics tmp = Graphics.FromImage(bmp);
        Graphics tmp2 = Graphics.FromImage(bmp2);


        //udp port stuff
        UdpClient MT_Client = new UdpClient();
        UdpClient WH_Client = new UdpClient();
        System.Net.IPEndPoint sending_end_point;

        int[,] rx_blocks = new int[8, 3];

        System.Timers.Timer timeout = new System.Timers.Timer();        //detect websocket timeout

        double start_freq = 10490.5f;


        XElement bandplan;
        Rectangle[] channels;
        IList<XElement> indexedbandplan;
        string InfoText;
        List<string> blocks = new List<string>();

        socket sock;
        signal sigs;

        int num_rxs_to_scan = 1;
        string rydebandinfo = "";

        bool comma_sep = false;


        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            Load += new EventHandler(Form1_Load);
        }






        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                Convert.ToSingle("0.5");
            }
            catch
            {
                comma_sep = true;
            }

            //Restore things here
            Properties.Settings.Default.Reload();
            foreach (String item in Properties.Settings.Default.ReceiverList)
            {
                string[] vals = item.Split(',');
                if (RxList.Columns.Count == vals.Length)
                {
                    RxList.Items.Add(new ListViewItem(vals));
                }
            }

            if (Properties.Settings.Default.Opacity > 0)
            {
                Opacity = Properties.Settings.Default.Opacity;
                trackBar_opacity.Value = Convert.ToInt16(Opacity * 100.0);
            }

            if (Properties.Settings.Default.Minimal)
            {
                checkBox_minimal.Checked = Properties.Settings.Default.Minimal;
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                button_close.Visible = true;

            }
            else
            {
                checkBox_minimal.Checked = false;
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                button_close.Visible = false;
            }

            //Location = Properties.Settings.Default.Location;

            //fix issue with screen hidden at X position = -32000 etc
            //if (this.Left < SystemInformation.VirtualScreen.X)
            //{
             //   this.Left = 0;
           // }

           




            try
            {
                bandplan = XElement.Load(Path.GetDirectoryName(Application.ExecutablePath) + @"\bandplan.xml");
                drawspectrum_bandplan();
                indexedbandplan = bandplan.Elements().ToList();
                foreach (var channel in bandplan.Elements("channel"))
                {
                    if (!blocks.Contains(channel.Element("block").Value))
                    {
                        blocks.Add(channel.Element("block").Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            sock = new socket();
            sigs = new signal(list_lock);
            sock.callback += drawspectrum;
            //sock.callback += sigs.detect_signals;
            //sigs.callback = drawspectrum_signals;
            string title = this.Text;
            this.Text = this.Text + " - Connecting to Server...";
            sock.start();
            this.Text = title;

            this.DoubleBuffered = true;
            update_count();


            //autotune recall

            combo_WaitTime.SelectedIndex = Properties.Settings.Default.scan_dwell ;
            combo_minsr.SelectedIndex = Properties.Settings.Default.scan_minsr ;
            if (RxList.Items.Count > 0)
            {
                if (Properties.Settings.Default.scan_numrx > -1)
                {
                    combo_rxs_scan.SelectedIndex = Properties.Settings.Default.scan_numrx;
                }
                
            }
            check_avoidbeacon.Checked = Properties.Settings.Default.avoidbeacon;


            //winterhill recall
            wh_ip.Text = Properties.Settings.Default.wh_ip;
            wh_port.Text = Properties.Settings.Default.wh_port;
            wh_lo.Text = Properties.Settings.Default.wh_lo;
            checkBox_wh_scan.Checked = Properties.Settings.Default.wh_scan_checked;
            combo_mode.SelectedIndex = Properties.Settings.Default.mode;


            sigs.set_num_rx_scan(num_rxs_to_scan);
            sigs.set_num_rx(RxList.Items.Count);


        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save things here
            System.Collections.Specialized.StringCollection Rxs = new System.Collections.Specialized.StringCollection();
            for (int a = 0; a < RxList.Items.Count; a++)
            {
                Rxs.Add(RxList.Items[a].SubItems[0].Text + "," + RxList.Items[a].SubItems[1].Text + "," + RxList.Items[a].SubItems[2].Text + "," + RxList.Items[a].SubItems[3].Text + "," + RxList.Items[a].SubItems[4].Text + "," + RxList.Items[a].SubItems[5].Text + "," + RxList.Items[a].SubItems[6].Text + "," + RxList.Items[a].SubItems[7].Text + "," + RxList.Items[a].SubItems[8].Text + "," + RxList.Items[a].SubItems[9].Text + "," + RxList.Items[a].SubItems[10].Text);
            }
            Properties.Settings.Default.ReceiverList = Rxs;
            Properties.Settings.Default.Opacity = Opacity;
            Properties.Settings.Default.Minimal = checkBox_minimal.Checked;
           // Properties.Settings.Default.Location = Location;

            //autotune
            Properties.Settings.Default.scan_dwell = combo_WaitTime.SelectedIndex;
            Properties.Settings.Default.scan_minsr = combo_minsr.SelectedIndex;
            Properties.Settings.Default.scan_numrx = combo_rxs_scan.SelectedIndex;
            Properties.Settings.Default.avoidbeacon = check_avoidbeacon.Checked;
            Properties.Settings.Default.mode = combo_mode.SelectedIndex;

            //winterhill
            Properties.Settings.Default.wh_ip = wh_ip.Text;
            Properties.Settings.Default.wh_port= wh_port.Text;
            Properties.Settings.Default.wh_lo = wh_lo.Text;
            Properties.Settings.Default.wh_scan_checked = checkBox_wh_scan.Checked;

            
            //finally save
            Properties.Settings.Default.Save();
        }




        private void drawspectrum_bandplan()
        {


            int span = 9;
            int count = 0;
            List<string> blocks = new List<string>();

            //count blocks ('layers' of bandplan)
            foreach (var channel in bandplan.Elements("channel"))
            {
                count++;
                if (!blocks.Contains(channel.Element("block").Value))
                {
                    blocks.Add(channel.Element("block").Value);
                }
            }

            channels = new Rectangle[count];

            int n = 0;

            //create rectangle blocks to display bandplan
            foreach (var channel in bandplan.Elements("channel"))
            {
                int w = 0;
                int offset = 0;
                float rolloff = 1.35f;
                string xval = channel.Element("x-freq").Value;

                float freq;
                int sr;
                
                if (comma_sep){        //detect whether ',' or '.' thousand separator!
                    freq = Convert.ToSingle(xval.Replace(".", ","));
                    sr = Convert.ToInt32(channel.Element("sr").Value.Replace(".", ","));
                }
                else
                {
                    freq = Convert.ToSingle(xval);
                    sr = Convert.ToInt32(channel.Element("sr").Value);
                }
                

                
              

                int pos = Convert.ToInt16((922.0 / span) * (freq - start_freq));
                w = Convert.ToInt32(sr / (span * 1000.0) * 922 * rolloff);

                int split = bandplan_height / blocks.Count();
                int b = blocks.Count();
                foreach (string blk in blocks)
                {
                    if (channel.Element("block").Value == blk)
                    {
                        offset = b * split;
                    }
                    b--;
                }
                channels[n] = new Rectangle(pos - (w / 2), offset - (split / 2) - 3, w, split - 2);
                n++;


            }

            //draw blocks
            for (int i = 0; i < count; i++)
            {
                tmp2.FillRectangles(bandplanBrush, new RectangleF[] { channels[i] });      //x,y,w,h
            }

        }

        private void drawspectrum_signals(List<signal.Sig> signals)
        {

            lock (list_lock)        //hopefully lock signals list while drawing
            {
                //draw the text for each signal found
                foreach (signal.Sig s in signals)
                {
                    tmp.DrawString(s.frequency.ToString("#.00") + "\n " + (s.sr * 1000).ToString("#Ks"), new Font("Tahoma", 10), Brushes.White, new PointF(Convert.ToSingle(s.fft_centre - 25), (255 - Convert.ToSingle(s.fft_strength + 38))));
                }
            }
            this.Invoke(new MethodInvoker(delegate () { spectrum.Image = bmp; spectrum.Update(); }));
        }


        private void drawspectrum(UInt16[] fft_data)
        {
            int receivers = RxList.Items.Count;
            tmp.Clear(Color.Black);     //clear canvas
            tmp.DrawImage(bmp2, new Point(0, spectrum.Height - bandplan_height)); //bandplan

            int spectrum_h = spectrum.Height - bandplan_height;

            //draw lines to segment y axis determining where to click for each receiver
            if (receivers >= 1)
            {
                int y = 0;
                int tyoffset = 0;
                for (int i = 0; i < receivers; i++)
                {
                    y = spectrum_h - ((spectrum_h / receivers) * i + 3);
                    tyoffset = (spectrum_h / receivers) / 2 + 10;
                    if (i > 0)
                    {
                        tmp.DrawLine(greypen, 0, y, 922, y);
                    }
                    tmp.DrawString((receivers - (i)).ToString(), new Font("Tahoma", 10), Brushes.White, new PointF(Convert.ToSingle(0), (spectrum_h - tyoffset - Convert.ToSingle((spectrum_h / receivers) * i + 1))));
                    if (rx_blocks[i, 0] > 0)
                    {
                        //draw block showing signal selected
                        tmp.FillRectangles(shadowBrush, new RectangleF[] { new System.Drawing.Rectangle(rx_blocks[i, 0] - (rx_blocks[i, 1] / 2), spectrum_h - y + 1, rx_blocks[i, 1], (spectrum_h / receivers) - 4) });

                    }
                }
            }


            for (int i = 1; i < fft_data.Length - 3; i++)     //ignore padding?
            {

                tmp.DrawLine(greenpen, i - 1, 255 - fft_data[i - 1] / 255, i, 255 - fft_data[i] / 255);
            }
            tmp.DrawString(InfoText, new Font("Tahoma", 12), Brushes.Yellow, new PointF(50, 0));

            drawspectrum_signals(sigs.detect_signals(fft_data));


            //pass bitmap to gui picture frame
        }

        private void spectrum_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            var pos = me.Location;

            int X = pos.X;
            int Y = pos.Y;
            if (me.Button == MouseButtons.Right)
            {
                select_signal(X, Y, "force", 0);
            }
            else
            {
                select_signal(X, Y, "normal", 0);
            }
        }



        //select_signal
        //
        //this function selects a signal on the spectrum based on the x/y position clicked in manual mode (or x/y and rx number sent from auto tune)
        //rx_blocks contains the grey rectangle information
        //force mode is when the user right clicks the spectrum to force a specific sr on a specific frequency
        //normal mode is used for left click to tune nearest signal and for auto tuning
        //tune commands are sent based on the rx number
        //
        //
        private void select_signal(int X, int Y, string tunemode, int _rx)
        {
            if (RxList.Items.Count > 0)       //check we have a receiver setup before sending anything!
            {
                if (tunemode=="force")
                {
                    int sr = 0;
                    int freq = Convert.ToInt32((10490.5 + (X / 922.0) * 9.0) * 1000.0);

                    bool ontop = false;
                    if (checkBox_ontop.Checked)
                    {
                        ontop = true;
                        checkBox_ontop.Checked = false;
                    }

                    using (SRForm edit = new SRForm(freq))      //open up the manual sr select form
                    {
                        edit.ShowDialog();
                        sr = edit.getsr();
                    }

                    checkBox_ontop.Checked = ontop;

                    int rx;
                    rx = determine_rx(Y);   //find receiver by vertical position clicked 
                    rx_blocks[rx, 0] = X;
                    rx_blocks[rx, 1] = Convert.ToInt16((sr / 9000.0) * 922);
                    rx_blocks[rx, 2] = rx;
                    sigs.set_tuned(new signal.Sig(0,0,X,0,freq,(float)sr/1000), rx);

                    //send tune commands
                    if (RxList.Items[rx].SubItems[9].Text == "Minitioune" | RxList.Items[rx].SubItems[9].Text == "WinterHill")
                    {
                        tune_minitioune(rx, freq, sr);
                    }
                    if (RxList.Items[rx].SubItems[9].Text == "Ryde")
                    {
                        tune_ryde(freq, sr, IPAddress.Parse(RxList.Items[rx].SubItems[0].Text), Convert.ToInt16(RxList.Items[rx].SubItems[1].Text), RxList.Items[rx].SubItems[10].Text);
                    }
                }

                if(tunemode=="normal")
                {
                    lock (list_lock)
                    {
                        foreach (signal.Sig s in sigs.signals)
                        {
                            if (X > s.fft_start & X < s.fft_stop)
                            {
                                int rx;
                                if (_rx > 0)        //auto tune rx number is above zero
                                {
                                    rx = _rx-1;  
                                }
                                else
                                {
                                    rx = determine_rx(Y);   //else find receiver by vertical position clicked
                                }
                                
                                sigs.set_tuned(s, rx);
                                rx_blocks[rx, 0] = Convert.ToInt16(s.fft_centre);
                                rx_blocks[rx, 1] = Convert.ToInt16(s.fft_stop - s.fft_start);
                                rx_blocks[rx, 2] = rx;
                                int freq = Convert.ToInt32((s.frequency) * 1000);
                                int sr = Convert.ToInt32((s.sr * 1000.0));
                                    
                                if (RxList.Items[rx].SubItems[9].Text == "Minitioune" | RxList.Items[rx].SubItems[9].Text == "WinterHill")
                                {
                                    tune_minitioune(rx,freq,sr);
                                }
                                if (RxList.Items[rx].SubItems[9].Text == "Ryde")
                                {
                                    tune_ryde(freq, sr, IPAddress.Parse(RxList.Items[rx].SubItems[0].Text), Convert.ToInt16(RxList.Items[rx].SubItems[1].Text), RxList.Items[rx].SubItems[10].Text);
                                }    
                            }
                        }
                    }
                } 
            }
        }


        private void tune_minitioune(int rx, int freq, int sr)
        {
            byte[] outStream = Encoding.ASCII.GetBytes("[GlobalMsg],Freq=" + freq.ToString() + ",Offset=" + RxList.Items[rx].SubItems[2].Text + ",Doppler=0,Srate=" + sr.ToString() + ",WideScan=" + RxList.Items[rx].SubItems[7].Text + ",LowSR=" + RxList.Items[rx].SubItems[8].Text + ",DVBmode=" + RxList.Items[rx].SubItems[6].Text + ",FPlug=" + RxList.Items[rx].SubItems[3].Text + ",Voltage=" + RxList.Items[rx].SubItems[4].Text + ",22kHz=" + RxList.Items[rx].SubItems[5].Text + "\n");
            IPAddress ip = IPAddress.Parse(RxList.Items[rx].SubItems[0].Text);
            int port = Convert.ToInt16(RxList.Items[rx].SubItems[1].Text);
            sending_end_point = new IPEndPoint(ip, port);
            try
            {
                MT_Client.Client.SendTo(outStream, sending_end_point);
            }
            catch
            {
                Console.WriteLine("Error sending UDP Command");
            }
            
        }


        private int determine_rx(int pos)
        {
            int rx = 0;
            int div = 255 / RxList.Items.Count;
            rx = pos / div;
            Console.WriteLine(rx);
        /*    switch (RxList.Items.Count)
            {
                case 1:
                    //use full v scale for selecting which Rx
                    break;
                case 2:
                    //use halves of v scale for selecting which Rx
                    if (pos > 127)
                    {
                        //Rx2
                        rx = 1;
                    }
                    else
                    {
                        //Rx1
                        rx = 0;
                    }
                    break;

                case 3:
                    //use thirds of v scale for selecting which Rx
                    if (pos > 170)
                    {
                        //Rx3
                        rx = 2;
                    }
                    else
                    {
                        if (pos > 85)
                        {
                            //Rx2
                            rx = 1;
                        }
                        else
                        {
                            //Rx1
                            rx = 0;
                        }

                    }
                    break;

                case 4:
                    //use quarters of v scale for selecting which Rx
                    if (pos > 192)
                    {
                        //Rx4
                        rx = 3;
                    }
                    else
                    {
                        if (pos > 128)
                        {
                            //Rx3
                            rx = 2;
                        }
                        else
                        {
                            if (pos > 64)
                            {
                                //Rx2
                                rx = 1;
                            }
                            else
                            {
                                //Rx1
                                rx = 0;
                            }
                        }

                    }
                    break;

            }
            */
            return rx;
        }


        private void spectrum_MouseMove(object sender, MouseEventArgs e)
        {

            //detect mouse over channel, tooltip info
            int n = 0;
            if (e.Y > (spectrum.Height - bandplan_height))
            {
                if (channels != null)
                {
                    foreach (Rectangle ch in channels)
                    {
                        if (e.X >= ch.Location.X & e.X <= ch.Location.X + ch.Width)
                        {
                            if (e.Y - (spectrum.Height - bandplan_height) >= ch.Location.Y - (ch.Height / 2) + 3 & e.Y - (spectrum.Height - bandplan_height) <= ch.Location.Y + (ch.Height / 2) + 3)
                            {
                                InfoText = indexedbandplan[n].Element("name").Value + "\nDn: " + indexedbandplan[n].Element("x-freq").Value + "\nUp: " + indexedbandplan[n].Element("s-freq").Value;
                            }

                        }
                        n++;
                    }
                }
            }
            else
            {
                if (InfoText != "")
                {
                    InfoText = "";
                }
            }

        }

        private void RxList_DoubleClick(object sender, EventArgs e)
        {
            if (RxList.SelectedIndices.Count > 0)
            {
                RxList.Items[RxList.SelectedIndices[0]].Remove();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RxList.SelectedIndices.Count > 0)
            {
                RxList.Items[RxList.SelectedIndices[0]].Remove();
            }
            update_count();
            sigs.set_num_rx(RxList.Items.Count);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_ontop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ontop.Checked)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }

        private void trackBar_opacity_Scroll(object sender, EventArgs e)
        {
            Opacity = ((double)trackBar_opacity.Value / 100.0);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
                Opacity = 1;
            else
                Opacity = ((double)trackBar_opacity.Value / 100.0);
        }


        private void checkBox_minimal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_minimal.Checked)
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                button_close.Visible = true;
            }
            else
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                button_close.Visible = false;
            }
        }


        //fix to allow drag when in 'minimal' mode
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //timer for auto scan
        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int n = 0; n < num_rxs_to_scan; n++) //RxList.Items.Count
            {
                float time;
                if (comma_sep){
                    time = Convert.ToSingle(combo_WaitTime.Text.Replace(".",","));
                }
                else
                {
                    time = Convert.ToSingle(combo_WaitTime.Text);
                }
                
                Tuple<signal.Sig, int> ret = sigs.tune(combo_mode.SelectedIndex, Convert.ToInt16(time * 60),n);
              //  Console.WriteLine(ret.Item1.frequency);
                if (ret.Item1.frequency > 0)      //above 0 is a change in signal
                {
                    System.Threading.Thread.Sleep(100);
                    select_signal(ret.Item1.fft_centre, ret.Item2, "normal", n+1);
                    sigs.set_tuned(ret.Item1, n);
                    rx_blocks[n, 0] = Convert.ToInt16(ret.Item1.fft_centre);
                    rx_blocks[n, 1] = Convert.ToInt16(ret.Item1.fft_stop - ret.Item1.fft_start);
                    rx_blocks[n, 2] = n;
                }
            }
        }

        //scan mode combo box
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_mode.SelectedIndex == 0)
            {
                timer1.Enabled = false;
            }
            if (combo_mode.SelectedIndex > 0)
            {
                timer1.Enabled = true;
            }
            tabPage1.Focus();       //remove highlight from text
        }


        //timer - connection dropped - auto reconnect
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sock != null)
            {
                TimeSpan t = DateTime.Now - sock.lastdata;

                if (t.Seconds >2)
                {
                    Console.WriteLine("Timeout, Disconnected");
                    sock.stop();
                }

                if (!sock.connected)
                {
                    sock.start();
                }
            }
        }



        private void tune_ryde(int freq, int sr, IPAddress ip, int port, string rydeband)
        {
            //TCP Send
            TcpClient tcpclnt;
            Stream stm;
            int len = 0;
            bool error = false;
            byte[] reply_array;
            byte[] outStream;

            if (rydebandinfo == "")     //get ryde band info on first command send
            {
                tcpclnt = new TcpClient();
                if (tcpclnt.ConnectAsync(ip, port).Wait(TimeSpan.FromSeconds(1)))   //wait 1 second in case of connection error
                {
                    stm = tcpclnt.GetStream();
                    stm.ReadTimeout = 3000;

                    JObject jobj = JObject.Parse("{'request':'getBands'}");     //convert string to json
                    string cmd = JsonConvert.SerializeObject(jobj);             //serialise json
                    outStream = new byte[1024];
                    outStream = Encoding.UTF8.GetBytes(cmd);                    //string to byte array
                    reply_array = new byte[1024];

                    try
                    {
                        stm.Write(outStream, 0, outStream.Length);              //send command
                        len = stm.Read(reply_array, 0, 1024);                   //get reply
                    }
                    catch (Exception ex)
                    {
                        error_label.Text = "Error:" + ex.Message;
                        error = true;
                    }
                    rydebandinfo = System.Text.Encoding.UTF8.GetString(reply_array, 0, len);     //reply string contains band information
                    tcpclnt.Close();
                }
                else
                {
                    error = true;
                }
            }
           



            if (!error)
            {
                tcpclnt = new TcpClient();
                len = 0;


                if (tcpclnt.ConnectAsync(ip, port).Wait(TimeSpan.FromSeconds(1)))       //wait 1 second in case of connection error
                {
                    stm = tcpclnt.GetStream();
                    stm.ReadTimeout = 3000;
                    JObject bands = JObject.Parse(rydebandinfo);     //convert string with band information (from above) to json
                    string band = bands["bands"][rydeband].ToString();  //get band from json data
                    string setTuneReq = "{ 'request':'setTune', 'tune':{ 'band':" + band + ", 'freq':" + freq.ToString() + ", 'sr':" + sr.ToString() + "} }";       //create tune string command with modified frequency/sr
                    JObject jobj = JObject.Parse(setTuneReq);       //convert to json
                    string cmd = JsonConvert.SerializeObject(jobj);        //json to string, won't accept string direct?
                    outStream = new byte[1024];
                    outStream = Encoding.UTF8.GetBytes(cmd);    //command string to byte array
                    reply_array = new byte[1024];

                    try
                    {
                        stm.Write(outStream, 0, outStream.Length);      //actually send command
                        len = stm.Read(reply_array, 0, 1024);           //get reply, for now do nothing with it
                    }
                    catch (Exception ex)
                    {
                        error_label.Text = "Error:" + ex.Message;
                        error_label.Refresh();
                    }
                    tcpclnt.Close();
                }
                else
                {
                    error = true;
                }
                tcpclnt.Close();
                error_label.Text = "";
            }
            else
            {
                error_label.Text = "Could not connect to Ryde!";
            }
        }


        AddRxForm add = new AddRxForm();

        private void button1_Click_2(object sender, EventArgs e)
        {
            bool ontop = false;
            if (checkBox_ontop.Checked)
            {
                ontop = true;
                checkBox_ontop.Checked = false;
            }
            //using (add)
            // {
            add.rx_added = "";
            add.ShowDialog();
            checkBox_ontop.Checked = ontop;


            if (RxList.Items.Count < 8)
            {
                if (add.rx_added == "Minitioune")
                {

                    RxList.Items.Add(new ListViewItem(new String[] { add.get_ip().ToString(), add.get_port().ToString(), add.get_lo().ToString(), add.get_rxsocket(), add.get_lnbvolts(), add.get_lnb22khz(), add.get_dvbmode(), add.get_widescan(), add.get_lowsr(), "Minitioune", "-" }));
                }
                if (add.rx_added == "Ryde")
                {
                    if (add.rydeband != "")
                    {
                        RxList.Items.Add(new ListViewItem(new String[] { add.get_ip().ToString(), add.get_port().ToString(), "-", "-", "-", "-", "-", "-", "-", "Ryde", add.get_rydeband() }));

                    }

                }
                if (add.rx_added == "WinterHill")
                {

                    RxList.Items.Add(new ListViewItem(new String[] { add.get_ip().ToString(), add.get_port().ToString(), add.get_lo().ToString(), add.get_rxsocket(), add.get_lnbvolts(), add.get_lnb22khz(), add.get_dvbmode(), add.get_widescan(), add.get_lowsr(), "WinterHill", "-" }));
                }
            }
            else
            {
                MessageBox.Show("Only 8 receivers allowed");
            }
              
           // }
            update_count();
            sigs.set_num_rx(RxList.Items.Count);
        }

        private void update_count()
        {
            combo_rxs_scan.Items.Clear();
            for (int n = 0; n < RxList.Items.Count; n++)
            {
                combo_rxs_scan.Items.Add(n + 1);
            }
            if (RxList.Items.Count > 0)
            {
                combo_rxs_scan.SelectedIndex = 0;
            }
            
            Console.WriteLine(combo_rxs_scan.SelectedIndex);
        }

        private void combo_minsr_SelectedIndexChanged(object sender, EventArgs e)
        {
            sigs.set_minsr(Convert.ToSingle(combo_minsr.GetItemText(combo_minsr.SelectedItem))/1000.0f);
        }

        private void combo_rxs_scan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(combo_rxs_scan.GetItemText(combo_rxs_scan.SelectedItem));
            //Console.WriteLine(combo_rxs_scan.SelectedIndex);
            num_rxs_to_scan = num;
            sigs.set_num_rx_scan(num);
            for(int i = num; i < 8; i++)
            {
                sigs.clear(i);
                rx_blocks[i, 0] = 0;
                rx_blocks[i, 1] = 0;
                rx_blocks[i, 2] = 0;
            }
            
        }




        //winterhill bits
        IPAddress winterhill_ip;
        int winterhill_port;
        IPEndPoint winterhill_end_point;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_wh_scan.Checked)
            {
                winterhill_ip = IPAddress.Parse(wh_ip.Text);
                winterhill_port = Convert.ToInt16(wh_port.Text);
                winterhill_end_point = new IPEndPoint(winterhill_ip, winterhill_port);
                timer_wh.Enabled = true;

            }
            else
            {
                timer_wh.Enabled = false;
            }
        }

        private void timer_wh_Tick(object sender, EventArgs e)
        {
            lock (list_lock)
            {
                foreach (signal.Sig s in sigs.signals)
                {
                    // Console.WriteLine( "[to@wh] rcv=0,freq=" + Convert.ToInt32(s.frequency*1000).ToString() + ",Srate=" + Convert.ToInt16(s.sr * 1000).ToString() + ",Offset=" + wh_lo.Text + "\n");
                    byte[] outStream = Encoding.ASCII.GetBytes("[to@wh] rcv=0,freq=" + Convert.ToInt32(s.frequency * 1000).ToString() + ",Srate=" + Convert.ToInt16(s.sr * 1000).ToString() + ",Offset=" + wh_lo.Text + "\n");
                    try
                    {
                        WH_Client.Client.SendTo(outStream, winterhill_end_point);
                    }
                    catch
                    {
                        Console.WriteLine("Error sending UDP Command");
                    }
                    
                }
            }
        }

        private void check_avoidbeacon_CheckedChanged(object sender, EventArgs e)
        {
            sigs.set_avoidbeacon(check_avoidbeacon.Checked);
        }
    }
}
