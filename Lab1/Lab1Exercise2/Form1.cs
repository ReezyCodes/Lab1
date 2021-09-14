using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Exercise2
{
    public partial class Form1 : Form
    {
        Queue<Int32> dataQueue = new Queue<Int32>();
        

        public Form1()
        {
            InitializeComponent();
            buttonEn.Click += ButtonEn_Click;
            buttonDe.Click += ButtonDe_Click;
            buttonAverage.Click += ButtonAverage_Click;
            System.Timers.Timer aTimer = new System.Timers.Timer(100);
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Enabled = true;
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            UpdateQueue();
        }

        private void ButtonAverage_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            decimal average = 0;

            if (dataQueue.Count < Convert.ToInt32(textBox4.Text))
            {
                MessageBox.Show("Bruh");
            }
            else
            {
                for (Int32 i = 0; i < Convert.ToInt32(textBox4.Text); i++)
                {
                    sum = sum + dataQueue.Dequeue();
                }
                average = sum / Convert.ToInt32(textBox4.Text);
                textBox5.Text = average.ToString();
            }
            UpdateQueue();
        }

        private void ButtonDe_Click(object sender, EventArgs e)
        {
            if (dataQueue.Count > 0)
            {
                dataQueue.Dequeue();
            }
            else
                {
                MessageBox.Show("Bruh");
            }
            UpdateQueue();
        }

        private void ButtonEn_Click(object sender, EventArgs e)
        {
            dataQueue.Enqueue(Convert.ToInt32(textBox1.Text));
            UpdateQueue();

        }

        private void UpdateQueue()
        {
            textBox6.Clear();
            textBox3.Text = dataQueue.Count.ToString();
            foreach(Int32 item in dataQueue)
            {
                textBox6.AppendText(item.ToString() + ", ");
            }
        }
    }
}
