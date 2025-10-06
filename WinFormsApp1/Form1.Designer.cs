using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 22);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Bengüsu Duman";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(445, 73);
            textBox1.Margin = new Padding(10);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(320, 300);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(38, 342);
            button1.Name = "button1";
            button1.Size = new Size(141, 44);
            button1.TabIndex = 2;
            button1.Text = "Görüntü Yükle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(205, 342);
            button2.Name = "button2";
            button2.Size = new Size(141, 44);
            button2.TabIndex = 3;
            button2.Text = "RGB Göster";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(38, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 42);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 5;
            label2.Text = "202585151014";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
