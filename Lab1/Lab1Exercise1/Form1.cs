using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.MouseMove += PictureBox1_MouseMove;
            pictureBox1.MouseClick += PictureBox1_MouseClick;
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtClick.AppendText("(" + e.X.ToString() + ", " + e.Y.ToString()+ ")");
            txtClick.AppendText(Environment.NewLine);
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            txtXPos.Text = e.X.ToString();
            txtYPos.Text = e.Y.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
