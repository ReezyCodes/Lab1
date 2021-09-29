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
        SerialPort serialPort1 = new SerialPort();
        int wait1 = 0, wait2 = 0, wait3 = 0;
        int state;

        public Form1()
        {
            InitializeComponent();
            textBoxAx.Text = "0";
            textBoxAy.Text = "0";
            textBoxAz.Text = "0";
            serialPort1.BaudRate = 9600;
            serialPort1.PortName = "COM3";
            serialPort1.DataBits = 8;
            serialPort1.Handshake = Handshake.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.Open();
            serialPort1.Write("A");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            serialPort1_DataReceived();
            int Ax = Convert.ToInt32(textBoxAx.Text);
            int Ay = Convert.ToInt32(textBoxAy.Text);
            int Az = Convert.ToInt32(textBoxAz.Text);

            if (Ax < 100 && wait1 == 0 && wait2 == 0 && wait3 == 0)
            {
                state = 1;
                wait1 = 5;
            }
            else if (state == 1)
            {
                wait1--;
                if (Ay < 130)
                {
                    state = 3;
                    wait2 = 5;
                }
                else if (wait1 == 0)
                {
                    textBoxState.Text = "Jab";
                    state = 0;
                    wait1 = 0;
                }

            }
            else if (state == 3)
            {
                wait2--;
                if (Az < 130)
                {
                    textBoxState.Text= "Right-Hook";
                    state = 0;
                    wait1 = 0;
                    wait2 = 0;
                    wait3 = 0;
                }
                else if (wait2 == 0)
                {
                    state = 0;
                    wait1 = 0;
                    wait2 = 0;
                    wait3 = 0;
                }
            }
            else if (Ay < 130 && wait1 == 0 && wait2 == 0 && wait3 == 0)
            {
                state = 2;
                wait3 = 5;
            }
            else if (state == 2)
            {
                wait3--;
                if (Ax < 100)
                {
                    textBoxState.Text = "High punch";
                    state = 0;
                    wait1 = 0;
                    wait2 = 0;
                    wait3 = 0;
                }
                else if (wait3 == 0)
                {
                    state = 0;
                    wait1 = 0;
                    wait2 = 0;
                    wait3 = 0;
                }
            }
            textBoxSerialDataStream.AppendText("(" + Ax.ToString() + ", " + Ay.ToString() + ", " + Az.ToString() + ", " + state.ToString() + ")" + ", ");
        }

        private void serialPort1_DataReceived()
        {
            int newByte;
            int bytesToRead;
            bytesToRead = serialPort1.BytesToRead;
            while (bytesToRead != 0)
            {
                newByte = serialPort1.ReadByte();
                dataQueue.Enqueue(Convert.ToInt32(newByte));
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
                    nextByte = 0;
                }
                bytesToRead = serialPort1.BytesToRead;
            }
    }
    }
}