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

namespace LabExam
{
    public partial class Form1 : Form
    {
        ConcurrentQueue<Int32> dataQueue = new ConcurrentQueue<Int32>();
        ConcurrentQueue<Int32> AxQueue = new ConcurrentQueue<Int32>();
        ConcurrentQueue<Int32> AyQueue = new ConcurrentQueue<Int32>();
        ConcurrentQueue<Int32> AzQueue = new ConcurrentQueue<Int32>();
        ConcurrentQueue<Int32> Ax2Queue = new ConcurrentQueue<Int32>();
        ConcurrentQueue<Int32> Ay2Queue = new ConcurrentQueue<Int32>();
        ConcurrentQueue<Int32> Az2Queue = new ConcurrentQueue<Int32>();
        int nextByte;
        int wait1 = 0, wait2 = 0, wait3 = 0, wait4 = 0, wait5 = 0;
        int state;
        int Ax = 0;
        int Ay = 0;
        int Az = 0;
        double sum1;
        double sum2;
        double sum3;
        double maxAx, minAx, maxAy, minAy, maxAz, minAz;

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
                if (newByte == 255 || nextByte == 0)
                {
                    nextByte = 1;
                }
                else if (nextByte == 1)
                {
                    if (newByte > 150)
                        textBoxOrientation.Text = "+X";
                    else if (newByte < 105)
                        textBoxOrientation.Text = "-X";
                    AxQueue.Enqueue(Convert.ToInt32(newByte));
                    Ax2Queue.Enqueue(Convert.ToInt32(newByte));
                    if (AxQueue.Count > 50)
                    {
                        sum1 = 0;
                        double avgAx;
                        for (int i = 0; i < 50; i++)
                        {
                            AxQueue.TryDequeue(out int Ax1);
                            sum1 += Ax1;
                        }
                        avgAx = ((sum1 / 50) - 127) / (153 - 127);
                        textBoxAxAvg.Text = avgAx.ToString("N2");
                    }
                    if (Ax2Queue.Count > 500)
                    {
                        maxAx = 0;
                        minAx = 180;
                        for (int i = 0; i < 500; i++)
                        {
                            Ax2Queue.TryDequeue(out int Ax1);
                            if (Ax1 > maxAx)
                                maxAx = Ax1;
                            else if (Ax1 < minAx)
                                minAx = Ax1;
                        }
                        maxAx = (maxAx - 127) / (153 - 127);
                        minAx = (minAx - 127) / (153 - 127);
                        textBoxAxMax.Text = minAx.ToString("N2") + ", " + maxAx.ToString("N2");
                    }
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
                    AyQueue.Enqueue(Convert.ToInt32(newByte));
                    Ay2Queue.Enqueue(Convert.ToInt32(newByte));
                    if (AyQueue.Count > 50)
                    {
                        double avgAy;
                        sum2 = 0;
                        for (int i = 0; i < 50; i++)
                        {
                            AyQueue.TryDequeue(out int Ay1);
                            sum2 += Ay1;
                        }
                        avgAy = ((sum2 / 50) - 127) / (153 - 127);
                        textBoxAyAvg.Text = avgAy.ToString("N2");
                    }
                    if (Ay2Queue.Count > 500)
                    {
                        maxAy = 0;
                        minAy = 180;
                        for (int i = 0; i < 500; i++)
                        {
                            Ay2Queue.TryDequeue(out int Ay1);
                            if (Ay1 > maxAy)
                                maxAy = Ay1;
                            else if (Ay1 < minAy)
                                minAy = Ay1;
                        }
                        maxAy = (maxAy - 127) / (153 - 127);
                        minAy = (minAy - 127) / (153 - 127);
                        textBoxAyMax.Text = minAy.ToString("N2") + ", " + maxAy.ToString("N2");
                    }
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
                    AzQueue.Enqueue(Convert.ToInt32(newByte));
                    Az2Queue.Enqueue(Convert.ToInt32(newByte));
                    if (AzQueue.Count > 50)
                    {
                        double avgAz;
                        sum3 = 0;
                        for (int i = 0; i < 50; i++)
                        {
                            AzQueue.TryDequeue(out int Az1);
                            sum3 += Az1;
                        }
                        avgAz = ((sum3 / 50) - 127) / (153 - 127);
                        textBoxAzAvg.Text = avgAz.ToString("N2");
                    }
                    if (Az2Queue.Count > 500)
                    {
                        maxAz = 0;
                        minAz = 180;
                        for (int i = 0; i < 500; i++)
                        {
                            Az2Queue.TryDequeue(out int Az1);
                            if (Az1 > maxAz)
                                maxAz = Az1;
                            else if (Az1 < minAz)
                                minAz = Az1;
                        }
                        maxAz = (maxAz - 127) / (153 - 127);
                        minAz = (minAz - 127) / (153 - 127);
                        textBoxAzMax.Text = minAz.ToString("N2") + ", " + maxAz.ToString("N2");
                    }
                    textBoxAz.Text = newByte.ToString();
                    Az = newByte;
                    nextByte = 0;
                }


                if (Ay > 180 && wait1 == 0 && wait2 == 0 && wait3 == 0 && wait4 == 0 && wait5 == 0)
                {
                    state = 1;
                    wait1 = 500;
                }
                else if (state == 1)
                {
                    wait1--;
                    //if (Ay > 180)
                    //{
                    //    state = 3;
                    //    wait2 = 500;
                    //}
                    if (wait1 == 0)
                    {
                        textBoxState.Text = "Go West";
                        state = 0;
                        wait1 = 0;
                        wait4 = 500;
                    }

                }
                else if (Az > 150 && wait1 == 0 && wait2 == 0 && wait3 == 0 && wait4 == 0 && wait5 == 0)
                {
                    state = 3;
                    wait2 = 500;
                }
                else if (state == 3)
                {
                    wait2--;
                    if (Ay > 170)
                    {
                        state = 4;
                        wait1 = 0;
                        wait2 = 0;
                        wait3 = 0;
                        wait4 = 0;
                        wait5 = 500;
                    }
                    else if (wait2 == 0)
                    {
                        state = 0;
                        wait1 = 0;
                        wait2 = 0;
                        wait3 = 0;
                        wait4 = 0;
                        wait5 = 0;
                    }
                }
                else if (state == 4)
                {
                    wait5--;
                    if (Ay > 170 && wait5 < 450)
                    {
                        textBoxState.Text = "Wave";
                        state = 0;
                        wait1 = 0;
                        wait2 = 0;
                        wait3 = 0;
                        wait4 = 500;
                        wait5 = 0;
                    }
                    else if (wait5 == 0)
                    {
                        state = 0;
                        wait1 = 0;
                        wait2 = 0;
                        wait3 = 0;
                        wait4 = 0;
                        wait5 = 0;
                    }
                }
                else if (Ax < 120 && wait1 == 0 && wait2 == 0 && wait3 == 0 && wait4 == 0 && wait5 == 0)
                {
                    state = 2;
                    wait3 = 500;
                }
                else if (state == 2)
                {
                    wait3--;
                    if (Ay > 170)
                    {
                        textBoxState.Text = "Frisbee";
                        state = 0;
                        wait1 = 0;
                        wait2 = 0;
                        wait3 = 0;
                        wait4 = 500;
                        wait5 = 0;
                    }
                    else if (wait3 == 0)
                    {
                        state = 0;
                        wait1 = 0;
                        wait2 = 0;
                        wait3 = 0;
                        wait4 = 0;
                        wait5 = 0;
                    }
                }
                else if (state == 0 && wait1 == 0 && wait2 == 0 && wait3 == 0 && wait4 > 0 && wait5 == 0)
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(serialPort2.IsOpen))
            {
                serialPort2.Open();
                serialPort2.Write("A");
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
            textBoxAx.Text = "0";
            textBoxAy.Text = "0";
            textBoxAz.Text = "0";

        }
    }
}