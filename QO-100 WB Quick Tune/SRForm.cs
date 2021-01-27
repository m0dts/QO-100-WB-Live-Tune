using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QO_100_WB_Quick_Tune
{
    public partial class SRForm : Form
    {
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label1;
        private Button button9;
        private Button button10;
        private Button button11;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button12;
        int freq = 0;

        public SRForm(int _freq)
        {
            freq = _freq;
            InitializeComponent();
            label2.Text = freq.ToString();
            
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(71, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 24);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "35";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(125, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 24);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "66";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(16, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 24);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.button3.Text = "125";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(70, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 24);
            this.button4.TabIndex = 3;
            this.button4.TabStop = false;
            this.button4.Text = "250";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(124, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 24);
            this.button5.TabIndex = 4;
            this.button5.TabStop = false;
            this.button5.Text = "333";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(17, 97);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 24);
            this.button6.TabIndex = 5;
            this.button6.TabStop = false;
            this.button6.Text = "500";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(70, 97);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 24);
            this.button7.TabIndex = 6;
            this.button7.TabStop = false;
            this.button7.Text = "1000";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(124, 97);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 24);
            this.button8.TabIndex = 7;
            this.button8.TabStop = false;
            this.button8.Text = "1500";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(37, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select SR";
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(17, 127);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 24);
            this.button9.TabIndex = 8;
            this.button9.TabStop = false;
            this.button9.Text = "2000";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(71, 127);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(48, 24);
            this.button10.TabIndex = 9;
            this.button10.TabStop = false;
            this.button10.Text = "4000";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button11.Location = new System.Drawing.Point(145, 8);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(27, 23);
            this.button11.TabIndex = 10;
            this.button11.Text = "X";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(70, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(27, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Frq:";
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(17, 37);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(48, 24);
            this.button12.TabIndex = 13;
            this.button12.TabStop = false;
            this.button12.Text = "25";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // SRForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(187, 201);
            this.ControlBox = false;
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SRForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        int SR = 0;

        public int getsr()
        {
            return SR;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SR = Convert.ToInt16((sender as Button).Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SR = Convert.ToInt16((sender as Button).Text);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SR = Convert.ToInt16((sender as Button).Text);
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SR = Convert.ToInt16((sender as Button).Text);
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SR = Convert.ToInt16((sender as Button).Text);
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SR = Convert.ToInt16((sender as Button).Text);
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SR = Convert.ToInt16((sender as Button).Text);
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SR = Convert.ToInt16((sender as Button).Text);
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SR = Convert.ToInt16((sender as Button).Text);
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SR = Convert.ToInt16((sender as Button).Text);
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SR = 0;
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SR = 25;
            this.Close();
        }
    }
}
