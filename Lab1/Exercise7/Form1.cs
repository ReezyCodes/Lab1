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

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Ax = Convert.ToInt32(textBoxAx.Text);
            int Ay = Convert.ToInt32(textBoxAy.Text);
            int Az = Convert.ToInt32(textBoxAz.Text);
            int state = 0;
            if (Ax >= 150)
                state = 1;
            else if (Ay >= 150)
                state = 2;
            else if (Az >= 150)
                state = 3;
            textBoxOrientation.Text = state.ToString();
            textBoxSerialDataStream.AppendText("(" + Ax.ToString() + ", " + Ay.ToString() + ", " + Az.ToString() + ", " + state.ToString() + ")" + ", ");
        }
    }
}