
namespace Exercise8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxSerialDataStream = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAx = new System.Windows.Forms.TextBox();
            this.textBoxAy = new System.Windows.Forms.TextBox();
            this.textBoxAz = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOrientation = new System.Windows.Forms.TextBox();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.textBoxWait1 = new System.Windows.Forms.TextBox();
            this.textBoxWait2 = new System.Windows.Forms.TextBox();
            this.textBoxWait4 = new System.Windows.Forms.TextBox();
            this.textBoxWait3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSerialDataStream
            // 
            this.textBoxSerialDataStream.Location = new System.Drawing.Point(32, 215);
            this.textBoxSerialDataStream.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSerialDataStream.Multiline = true;
            this.textBoxSerialDataStream.Name = "textBoxSerialDataStream";
            this.textBoxSerialDataStream.Size = new System.Drawing.Size(592, 419);
            this.textBoxSerialDataStream.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data History";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Az";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ay";
            // 
            // textBoxAx
            // 
            this.textBoxAx.Location = new System.Drawing.Point(64, 15);
            this.textBoxAx.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxAx.Name = "textBoxAx";
            this.textBoxAx.Size = new System.Drawing.Size(102, 31);
            this.textBoxAx.TabIndex = 14;
            // 
            // textBoxAy
            // 
            this.textBoxAy.Location = new System.Drawing.Point(296, 15);
            this.textBoxAy.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxAy.Name = "textBoxAy";
            this.textBoxAy.Size = new System.Drawing.Size(102, 31);
            this.textBoxAy.TabIndex = 15;
            // 
            // textBoxAz
            // 
            this.textBoxAz.Location = new System.Drawing.Point(524, 15);
            this.textBoxAz.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxAz.Name = "textBoxAz";
            this.textBoxAz.Size = new System.Drawing.Size(102, 31);
            this.textBoxAz.TabIndex = 16;
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(420, 154);
            this.textBoxState.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(196, 31);
            this.textBoxState.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Current State";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Orientation";
            // 
            // textBoxOrientation
            // 
            this.textBoxOrientation.Location = new System.Drawing.Point(420, 112);
            this.textBoxOrientation.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxOrientation.Name = "textBoxOrientation";
            this.textBoxOrientation.Size = new System.Drawing.Size(196, 31);
            this.textBoxOrientation.TabIndex = 24;
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM3";
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // textBoxWait1
            // 
            this.textBoxWait1.Location = new System.Drawing.Point(32, 646);
            this.textBoxWait1.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxWait1.Name = "textBoxWait1";
            this.textBoxWait1.Size = new System.Drawing.Size(102, 31);
            this.textBoxWait1.TabIndex = 26;
            // 
            // textBoxWait2
            // 
            this.textBoxWait2.Location = new System.Drawing.Point(33, 689);
            this.textBoxWait2.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxWait2.Name = "textBoxWait2";
            this.textBoxWait2.Size = new System.Drawing.Size(102, 31);
            this.textBoxWait2.TabIndex = 27;
            // 
            // textBoxWait4
            // 
            this.textBoxWait4.Location = new System.Drawing.Point(32, 775);
            this.textBoxWait4.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxWait4.Name = "textBoxWait4";
            this.textBoxWait4.Size = new System.Drawing.Size(102, 31);
            this.textBoxWait4.TabIndex = 28;
            // 
            // textBoxWait3
            // 
            this.textBoxWait3.Location = new System.Drawing.Point(32, 732);
            this.textBoxWait3.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxWait3.Name = "textBoxWait3";
            this.textBoxWait3.Size = new System.Drawing.Size(102, 31);
            this.textBoxWait3.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 888);
            this.Controls.Add(this.textBoxWait3);
            this.Controls.Add(this.textBoxWait4);
            this.Controls.Add(this.textBoxWait2);
            this.Controls.Add(this.textBoxWait1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOrientation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.textBoxAz);
            this.Controls.Add(this.textBoxAy);
            this.Controls.Add(this.textBoxAx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSerialDataStream);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSerialDataStream;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAx;
        private System.Windows.Forms.TextBox textBoxAy;
        private System.Windows.Forms.TextBox textBoxAz;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOrientation;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.TextBox textBoxWait1;
        private System.Windows.Forms.TextBox textBoxWait2;
        private System.Windows.Forms.TextBox textBoxWait4;
        private System.Windows.Forms.TextBox textBoxWait3;
    }
}

