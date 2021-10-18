using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_6
{
    public partial class Form1 : Form
    {
        ConcurrentQueue<Int32> dataQueue = new ConcurrentQueue<Int32>();
        int nextByte, thermo;
        string MSB, LSB, Combo;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int bytesToRead;
            int newByte;
            bytesToRead = serialPort2.BytesToRead;
            textBoxSerialBuffer.Text = bytesToRead.ToString();
            textBoxQueueSize.Text = dataQueue.Count.ToString();
            while (dataQueue.TryDequeue(out newByte) == true)
            {
                textBoxSerialDataStream.AppendText(newByte.ToString() + ", ");
                if (newByte == 255)
                {
                    nextByte = 1;
                }
                else if (nextByte == 1)
                {
                    MSB = Convert.ToString(newByte, 2);
                    for (int i = MSB.Length; i < 5; i++)
                        MSB = MSB + "0";
                    textBoxMSB.Text = MSB;
                    nextByte = 2;
                }
                else if (nextByte == 2)
                {
                    LSB = Convert.ToString(newByte, 2);
                    for (int i = LSB.Length; i < 5; i++)
                        LSB = LSB + "0";
                    textBoxLSB.Text = LSB;
                    Combo = MSB + LSB;
                    textBoxCombo.Text = Combo;
                    thermo = Convert.ToInt32(Combo, 2);
                    textBoxThermo.Text = Convert.ToString(thermo);
                    nextByte = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(serialPort2.IsOpen))
            {
                serialPort2.Open();
                serialPort2.Write("c");
                button1.Text = "Disconnect Serial";
                timer1.Enabled = true;
            }
            else if (serialPort2.IsOpen)
            {
                serialPort2.Close();
                button1.Text = "Connect Serial";
                timer1.Enabled = false;
            }
        }

        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int newByte;
            int bytesToRead;
            bytesToRead = serialPort2.BytesToRead;
            while (bytesToRead != 0)
            {
                newByte = serialPort2.ReadByte();
                dataQueue.Enqueue(Convert.ToInt32(newByte));
                bytesToRead = serialPort2.BytesToRead;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}