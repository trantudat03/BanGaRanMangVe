﻿namespace GUI
{
    partial class FHuyDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHuyDon));
            this.label1 = new System.Windows.Forms.Label();
            this.txb_LyDo = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lý Do Hủy Đơn";
            // 
            // txb_LyDo
            // 
            this.txb_LyDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_LyDo.Location = new System.Drawing.Point(93, 98);
            this.txb_LyDo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_LyDo.Multiline = true;
            this.txb_LyDo.Name = "txb_LyDo";
            this.txb_LyDo.Size = new System.Drawing.Size(344, 129);
            this.txb_LyDo.TabIndex = 1;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Submit.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Submit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Submit.Image")));
            this.btn_Submit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Submit.Location = new System.Drawing.Point(93, 331);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(138, 52);
            this.btn_Submit.TabIndex = 2;
            this.btn_Submit.Text = "Xác Nhận";
            this.btn_Submit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // FHuyDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 495);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txb_LyDo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FHuyDon";
            this.Text = "Hủy Đơn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_LyDo;
        private System.Windows.Forms.Button btn_Submit;
    }
}