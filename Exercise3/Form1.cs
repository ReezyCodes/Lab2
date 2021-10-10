using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Form1 : Form
    {
        int wait = 0;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var rand = new Random();
            serialPort1.Write("5");
            int r = rand.Next(255);
            int g = rand.Next(255);
            int b = rand.Next(255);
            button1.BackColor = Color.FromArgb(r,g,b);
            timerHalf.Enabled = true;
            timerRNG.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            int num = rand.Next(200,1000);
            textBoxRand.Text = num.ToString();
            timerRNG.Interval = num;
            timerRNG.Enabled = true;
        }

        private void timerHalf_Tick(object sender, EventArgs e)
        {
            serialPort1.Write("%");
            timerHalf.Enabled = false;
        }
    }
}
