
namespace Lab1Exercise3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEn = new System.Windows.Forms.Button();
            this.buttonDe = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonAverage = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // buttonEn
            // 
            this.buttonEn.Location = new System.Drawing.Point(6, 6);
            this.buttonEn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonEn.Name = "buttonEn";
            this.buttonEn.Size = new System.Drawing.Size(81, 22);
            this.buttonEn.TabIndex = 1;
            this.buttonEn.Text = "Enqueue";
            this.buttonEn.UseVisualStyleBackColor = true;
            // 
            // buttonDe
            // 
            this.buttonDe.Location = new System.Drawing.Point(6, 30);
            this.buttonDe.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonDe.Name = "buttonDe";
            this.buttonDe.Size = new System.Drawing.Size(81, 22);
            this.buttonDe.TabIndex = 2;
            this.buttonDe.Text = "Dequeue";
            this.buttonDe.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 32);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 23);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Items in Queue";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(109, 57);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 23);
            this.textBox3.TabIndex = 6;
            // 
            // buttonAverage
            // 
            this.buttonAverage.Location = new System.Drawing.Point(6, 83);
            this.buttonAverage.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(263, 22);
            this.buttonAverage.TabIndex = 7;
            this.buttonAverage.Text = "Dequeue and Average First N Data Points";
            this.buttonAverage.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 113);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 22);
            this.button4.TabIndex = 8;
            this.button4.Text = "N";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(99, 115);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(110, 23);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(99, 143);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(110, 23);
            this.textBox5.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 142);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 22);
            this.button5.TabIndex = 10;
            this.button5.Text = "Average";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 180);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(269, 195);
            this.textBox6.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Queue Contents";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 378);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonAverage);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDe);
            this.Controls.Add(this.buttonEn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEn;
        private System.Windows.Forms.Button buttonDe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonAverage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

