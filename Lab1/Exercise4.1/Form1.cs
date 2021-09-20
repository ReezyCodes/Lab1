using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections.Concurrent;

namespace Exercise4._1
{
    public partial class Form1 : Form
    {
        string serialDataString;
        SerialPort _serialPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
        ConcurrentQueue<Int32> dataQueue = new ConcurrentQueue<Int32>();

        public Form1()
        {
            InitializeComponent();

            listBox1.Items.Clear();
            listBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (listBox1.Items.Count == 0)
                listBox1.Text = "No COM ports!";
            else
                listBox1.SelectedIndex = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(_serialPort.IsOpen))
            {
                _serialPort.Open();
                _serialPort.Handshake = Handshake.None;
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
            bytesToRead = _serialPort.BytesToRead;
            while (bytesToRead != 0)
            {
                newByte = _serialPort.ReadByte();
                serialDataString = serialDataString + newByte.ToString() + ", ";
                dataQueue.Enqueue(Convert.ToInt32(newByte));
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
                int byteOut;
                int bytesToRead;
                bytesToRead = _serialPort.BytesToRead;
                while (dataQueue.TryDequeue(out byteOut) == true)
                {
                    textBoxSerialDataStream.AppendText(byteOut.ToString() + ", ");
                }
            }
        }
    }
}