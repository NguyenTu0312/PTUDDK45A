﻿namespace BaiThucHanhBuoi1
{
    partial class MainFrom
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
            this.button1 = new System.Windows.Forms.Button();
            this.Ten = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.abc = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SaoChep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nhập tên của bạn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ten
            // 
            this.Ten.Location = new System.Drawing.Point(283, 31);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(183, 20);
            this.Ten.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xử Lý";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // abc
            // 
            this.abc.Location = new System.Drawing.Point(391, 57);
            this.abc.Name = "abc";
            this.abc.Size = new System.Drawing.Size(75, 23);
            this.abc.TabIndex = 3;
            this.abc.Text = "Sao chép";
            this.abc.UseVisualStyleBackColor = true;
            this.abc.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(120, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Bạn đã nhập";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // SaoChep
            // 
            this.SaoChep.Location = new System.Drawing.Point(283, 87);
            this.SaoChep.Name = "SaoChep";
            this.SaoChep.Size = new System.Drawing.Size(183, 20);
            this.SaoChep.TabIndex = 5;
            this.SaoChep.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaoChep);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.abc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Ten);
            this.Controls.Add(this.button1);
            this.Name = "MainFrom";
            this.Text = "Chương Trình Đầu Tiên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Ten;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button abc;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox SaoChep;
    }
}

