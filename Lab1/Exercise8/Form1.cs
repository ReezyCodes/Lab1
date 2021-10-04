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

namespace Exercise8
{
    public partial class Form1 : Form
    {
        ConcurrentQueue<Int32> dataQueue = new ConcurrentQueue<Int32>();
        int nextByte;
        int wait1 = 0, wait2 = 0, wait3 = 0, wait4 = 0;
        int state;
        int Ax = 0;
        int Ay = 0;
        int Az = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int bytesToRead;
            int newByte;
            bytesToRead = serialPort2.BytesToRead;
            while (dataQueue.TryDequeue(out newByte) == true)
            {
                textBoxSerialDataStream.AppendText(newByte.ToString() + ", ");
                //serialDataString = serialDataString + newByte.ToString() + ", ";
                if (newByte == 255 || nextByte == 0)
                {
                    //textBoxSerialDataStream.AppendText(newByte.ToString() + ", ");
                    nextByte = 1;
                }
                else if (nextByte == 1)
                {
                    if (newByte > 150)
                        textBoxOrientation.Text = "+X";
                    else if (newByte < 105)
                        textBoxOrientation.Text = "-X";
                    //textBoxSerialDataStream.AppendText(newByte.ToString() + ", ");
                    textBoxAx.Text = newByte.ToString();
                    Ax = newByte;
                    nextByte = 2;
                }
                else if (nextByte == 2)
                {
                    if (newByte > 150)
                        textBoxOrientation.Text = "+Y";
                    else if (newByte < 105)
                        textBoxOrientation.Text = "-Y";
                    //textBoxSerialDataStream.AppendText(newByte.ToString() + ", ");
                    textBoxAy.Text = newByte.ToString();
                    Ay = newByte;
                    nextByte = 3;
                }
                else if (nextByte == 3)
                {
                    if (newByte > 150)
                        textBoxOrientation.Text = "+Z";
                    else if (newByte < 105)
                        textBoxOrientation.Text = "-Z";
                    //textBoxSerialDataStream.AppendText(newByte.ToString() + ", ");
                    textBoxAz.Text = newByte.ToString();
                    Az = newByte;
                    nextByte = 0;
                }

                if (Ax < 120 && wait1 == 0 && wait2 == 0 && wait3 == 0 && wait4 == 0)
                {
                    state = 1;
                    wait1 = 500;
                }
                else if (state == 1)
                {
                    wait1--;
                    if (Ay > 180)
                    {
                        state = 3;
                        wait2 = 500;
                    }
                    else if (wait1 == 0)
                    {
                        textBoxState.Text = "Jab";
                        state = 0;
                        wait1 = 0;
                        wait4 = 500;
                    }

                }
                else if (state == 3)
                {
                    wait2--;
                    if (Az < 100)
                    {
                        textBoxState.Text = "Right-Hook";
                        state = 0;
                        wait1 = 0;
                        wait2 = 0;
                        wait3 = 0;
                        wait4 = 500;
                    }
                    else if (wait2 == 0)
                    {
                        state = 0;
                        wait1 = 0;
                        wait2 = 0;
                        wait3 = 0;
                        wait4 = 0;
                    }
                }
                else if (Ay > 180 && wait1 == 0 && wait2 == 0 && wait3 == 0 && wait4 == 0)
                {
                    state = 2;
                    wait3 = 500;
                }
                else if (state == 2)
                {
                    wait3--;
                    if (Ax < 120)
                    {
                        textBoxState.Text = "High punch";
                        state = 0;
                        wait1 = 0;
                        wait2 = 0;
                        wait3 = 0;
                        wait4 = 500;
                    }
                    else if (wait3 == 0)
                    {
                        state = 0;
                        wait1 = 0;
                        wait2 = 0;
                        wait3 = 0;
                        wait4 = 0;
                    }
                }
                else if (state == 0 && wait1 == 0 && wait2 == 0 && wait3 == 0 && wait4 > 0)
                {
                    wait4--;
                    if (wait4 == 0)
                    {
                        textBoxState.Text = "";
                        wait4 = 0;
                    }
                    else if (wait4 < 0)
                        wait4 = 0;

                }
                textBoxWait1.Text = wait1.ToString();
                textBoxWait2.Text = wait2.ToString();
                textBoxWait3.Text = wait3.ToString();
                textBoxWait4.Text = wait4.ToString();

                //textBoxSerialDataStream.AppendText("(" + Ax.ToString() + ", " + Ay.ToString() + ", " + Az.ToString() + ", " + state.ToString() + ")" + ", ");
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
                //serialDataString = serialDataString + newByte.ToString() + ", ";
                dataQueue.Enqueue(Convert.ToInt32(newByte));
                bytesToRead = serialPort2.BytesToRead;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort2.Open();
            serialPort2.Write("A");
        }

        public Form1()
        {
            InitializeComponent();
            textBoxAx.Text = "0";
            textBoxAy.Text = "0";
            textBoxAz.Text = "0";
            
        }

        
    }
}