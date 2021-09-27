
namespace Exercise7
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
            this.textBoxBytesToRead = new System.Windows.Forms.TextBox();
            this.textBoxTempStringLength = new System.Windows.Forms.TextBox();
            this.textBoxItemsQueue = new System.Windows.Forms.TextBox();
            this.serialButton = new System.Windows.Forms.Button();
            this.textBoxSerialDataStream = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAx = new System.Windows.Forms.TextBox();
            this.textBoxAy = new System.Windows.Forms.TextBox();
            this.textBoxAz = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxOrientation = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonFilename = new System.Windows.Forms.Button();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxBytesToRead
            // 
            this.textBoxBytesToRead.Location = new System.Drawing.Point(162, 49);
            this.textBoxBytesToRead.Name = "textBoxBytesToRead";
            this.textBoxBytesToRead.Size = new System.Drawing.Size(100, 20);
            this.textBoxBytesToRead.TabIndex = 1;
            // 
            // textBoxTempStringLength
            // 
            this.textBoxTempStringLength.Location = new System.Drawing.Point(162, 75);
            this.textBoxTempStringLength.Name = "textBoxTempStringLength";
            this.textBoxTempStringLength.Size = new System.Drawing.Size(100, 20);
            this.textBoxTempStringLength.TabIndex = 2;
            // 
            // textBoxItemsQueue
            // 
            this.textBoxItemsQueue.Location = new System.Drawing.Point(162, 101);
            this.textBoxItemsQueue.Name = "textBoxItemsQueue";
            this.textBoxItemsQueue.Size = new System.Drawing.Size(100, 20);
            this.textBoxItemsQueue.TabIndex = 3;
            // 
            // serialButton
            // 
            this.serialButton.Location = new System.Drawing.Point(162, 14);
            this.serialButton.Name = "serialButton";
            this.serialButton.Size = new System.Drawing.Size(122, 23);
            this.serialButton.TabIndex = 4;
            this.serialButton.Text = "Connect Serial";
            this.serialButton.UseVisualStyleBackColor = true;
            this.serialButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSerialDataStream
            // 
            this.textBoxSerialDataStream.Location = new System.Drawing.Point(12, 157);
            this.textBoxSerialDataStream.Multiline = true;
            this.textBoxSerialDataStream.Name = "textBoxSerialDataStream";
            this.textBoxSerialDataStream.Size = new System.Drawing.Size(298, 220);
            this.textBoxSerialDataStream.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Serial Bytes to Read";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Temp String Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Items in Queue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Serial Data Stream";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Az";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ay";
            // 
            // textBoxAx
            // 
            this.textBoxAx.Location = new System.Drawing.Point(36, 381);
            this.textBoxAx.Name = "textBoxAx";
            this.textBoxAx.Size = new System.Drawing.Size(53, 20);
            this.textBoxAx.TabIndex = 14;
            // 
            // textBoxAy
            // 
            this.textBoxAy.Location = new System.Drawing.Point(148, 381);
            this.textBoxAy.Name = "textBoxAy";
            this.textBoxAy.Size = new System.Drawing.Size(53, 20);
            this.textBoxAy.TabIndex = 15;
            // 
            // textBoxAz
            // 
            this.textBoxAz.Location = new System.Drawing.Point(258, 381);
            this.textBoxAz.Name = "textBoxAz";
            this.textBoxAz.Size = new System.Drawing.Size(53, 20);
            this.textBoxAz.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // textBoxOrientation
            // 
            this.textBoxOrientation.Location = new System.Drawing.Point(210, 138);
            this.textBoxOrientation.Name = "textBoxOrientation";
            this.textBoxOrientation.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrientation.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 405);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Save to File";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonFilename
            // 
            this.buttonFilename.Location = new System.Drawing.Point(12, 436);
            this.buttonFilename.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFilename.Name = "buttonFilename";
            this.buttonFilename.Size = new System.Drawing.Size(119, 20);
            this.buttonFilename.TabIndex = 20;
            this.buttonFilename.Text = "Select Filename";
            this.buttonFilename.UseVisualStyleBackColor = true;
            this.buttonFilename.Click += new System.EventHandler(this.buttonFilename_Click);
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.Location = new System.Drawing.Point(148, 436);
            this.textBoxFilename.Multiline = true;
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.Size = new System.Drawing.Size(163, 20);
            this.textBoxFilename.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 462);
            this.Controls.Add(this.textBoxFilename);
            this.Controls.Add(this.buttonFilename);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxOrientation);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxAz);
            this.Controls.Add(this.textBoxAy);
            this.Controls.Add(this.textBoxAx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSerialDataStream);
            this.Controls.Add(this.serialButton);
            this.Controls.Add(this.textBoxItemsQueue);
            this.Controls.Add(this.textBoxTempStringLength);
            this.Controls.Add(this.textBoxBytesToRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBytesToRead;
        private System.Windows.Forms.TextBox textBoxTempStringLength;
        private System.Windows.Forms.TextBox textBoxItemsQueue;
        private System.Windows.Forms.Button serialButton;
        private System.Windows.Forms.TextBox textBoxSerialDataStream;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAx;
        private System.Windows.Forms.TextBox textBoxAy;
        private System.Windows.Forms.TextBox textBoxAz;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxOrientation;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonFilename;
        private System.Windows.Forms.TextBox textBoxFilename;
    }
}

