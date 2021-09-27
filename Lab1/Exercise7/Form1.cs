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

namespace Exercise7
{
    public partial class Form1 : Form
    {
        string serialDataString = "";
        SerialPort _serialPort = new SerialPort();
        ConcurrentQueue<Int32> dataQueue = new ConcurrentQueue<Int32>();
        ConcurrentQueue<Int32> moveQueue = new ConcurrentQueue<Int32>();
        int nextByte;
        StreamWriter outputfile;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
            if (comboBox1.Items.Count == 0)
                comboBox1.Text = "No COM ports!";
            else
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!(_serialPort.IsOpen))
            {
                _serialPort.BaudRate = 9600;
                _serialPort.PortName = comboBox1.SelectedItem.ToString();
                _serialPort.DataBits = 8;
                _serialPort.Handshake = Handshake.None;
                _serialPort.StopBits = StopBits.One;
                _serialPort.Open();
                _serialPort.Write("A");
                serialButton.Text = "Disconnect Serial";
            }
            else if (_serialPort.IsOpen)
            {
                _serialPort.Close();
                serialButton.Text = "Connect Serial";
            }
            this.timer1.Enabled = true;
        }
        private void serialPort_DataReceived()
        {
            int newByte;
            int bytesToRead;
            int wait1;
            int wait2;
            int wait3;
            bytesToRead = _serialPort.BytesToRead;
            while (bytesToRead != 0)
            {
                newByte = _serialPort.ReadByte();
                dataQueue.Enqueue(Convert.ToInt32(newByte));
                serialDataString = serialDataString + newByte.ToString() + ", ";
                if (newByte == 255 || nextByte == 0)
                {
                    textBoxSerialDataStream.AppendText(newByte.ToString() + ", ");
                    nextByte = 1;
                }
                else if (nextByte == 1)
                {
                    if (newByte > 150)
                        textBoxOrientation.Text = "On Side";
                    textBoxSerialDataStream.AppendText(newByte.ToString() + ", ");
                    moveQueue.Enqueue(Convert.ToInt32(newByte));
                    textBoxAx.Text = newByte.ToString();
                    if (checkBox1.Checked == true)
                        outputfile.Write(textBoxAx.Text + ",");
                    nextByte = 2;
                }
                else if (nextByte == 2)
                {
                    if (newByte > 150)
                        textBoxOrientation.Text = "Upright";
                    textBoxSerialDataStream.AppendText(newByte.ToString() + ", ");
                    moveQueue.Enqueue(Convert.ToInt32(newByte));
                    textBoxAy.Text = newByte.ToString();
                    if (checkBox1.Checked == true)
                        outputfile.Write(textBoxAy.Text + ",");
                    nextByte = 3;
                }
                else if (nextByte == 3)
                {
                    if (newByte > 150)
                        textBoxOrientation.Text = "Flat";
                    textBoxSerialDataStream.AppendText(newByte.ToString() + ", ");
                    moveQueue.Enqueue(Convert.ToInt32(newByte));
                    textBoxAz.Text = newByte.ToString();
                    if (checkBox1.Checked == true)
                        outputfile.Write(textBoxAz.Text + "," + DateTime.Now.ToString("hh.mm.ss.ffffff") + "\n");
                    nextByte = 0;
                }
                bytesToRead = _serialPort.BytesToRead;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                serialPort_DataReceived();
                textBoxBytesToRead.Text = _serialPort.BytesToRead.ToString();
                textBoxTempStringLength.Text = serialDataString.Length.ToString();
                textBoxItemsQueue.Text = dataQueue.Count.ToString();
                serialDataString = "";
                while (dataQueue.TryDequeue(out int byteOut) == true)
                {
                }
            }
        }

        private void buttonFilename_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\Users\Home\source\repos\ReezyCodes\Lab1\Lab1\Exercise7\bin\Debug\Files";
            saveFileDialog1.ShowDialog();
            textBoxFilename.Text = saveFileDialog1.FileName.ToString() + ".CSV";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                outputfile = new StreamWriter(textBoxFilename.Text);
            }
            else
                outputfile.Close();
        }
    }
}