﻿namespace Reestr2
{
    partial class services
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Снять наличные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "Выписка по счету";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите одну из услуг";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 73);
            this.button3.TabIndex = 3;
            this.button3.Text = "Завершить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(217, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 73);
            this.button4.TabIndex = 4;
            this.button4.Text = "Пополнить счет";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 305);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "services";
            this.Text = "services";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}