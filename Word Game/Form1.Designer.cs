﻿namespace Word_Game
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(136, 79);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 118);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 2;
            label1.Text = "(1)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 147);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 3;
            label2.Text = "(2)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 175);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 4;
            label3.Text = "(3)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 205);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 5;
            label4.Text = "(4)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 235);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 6;
            label5.Text = "(5)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 118);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 7;
            label6.Text = "(6)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(136, 51);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 8;
            label7.Text = "Score = 0 ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 51);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 9;
            label8.Text = "Prompt :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 24);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 10;
            label9.Text = "Timer = 100";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(159, 175);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 11;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(91, 147);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 12;
            label11.Text = "(7)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(91, 175);
            label12.Name = "label12";
            label12.Size = new Size(21, 15);
            label12.TabIndex = 13;
            label12.Text = "(8)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(91, 205);
            label13.Name = "label13";
            label13.Size = new Size(21, 15);
            label13.TabIndex = 14;
            label13.Text = "(9)";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(91, 235);
            label14.Name = "label14";
            label14.Size = new Size(27, 15);
            label14.TabIndex = 15;
            label14.Text = "(10)";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 265);
            label15.Name = "label15";
            label15.Size = new Size(160, 45);
            label15.TabIndex = 16;
            label15.Text = "Tip : Think of as many words \r\nas you can that match the \r\nprompt within 100s";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 328);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private System.Windows.Forms.Timer timer1;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
    }
}