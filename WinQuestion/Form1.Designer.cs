﻿namespace WinQuestion
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
            this.btnyes = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnyes
            // 
            this.btnyes.Location = new System.Drawing.Point(79, 82);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(75, 23);
            this.btnyes.TabIndex = 0;
            this.btnyes.Text = "Yes";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(177, 82);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(75, 23);
            this.btnno.TabIndex = 1;
            this.btnno.Text = "No";
            this.btnno.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ви задоволені своєю заробітною платою?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 149);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnyes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Нагальне питання";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}