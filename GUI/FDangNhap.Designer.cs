﻿namespace GUI
{
    partial class FDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDangNhap));
            this.txb_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_MatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_ThongBaoTDN = new System.Windows.Forms.Label();
            this.lbl_ThongBao = new System.Windows.Forms.Label();
            this.lbl_QuenMK = new System.Windows.Forms.Label();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_eyePass = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eyePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_TenDangNhap
            // 
            this.txb_TenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_TenDangNhap.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TenDangNhap.Location = new System.Drawing.Point(24, 74);
            this.txb_TenDangNhap.Margin = new System.Windows.Forms.Padding(10);
            this.txb_TenDangNhap.MaximumSize = new System.Drawing.Size(400, 100);
            this.txb_TenDangNhap.MinimumSize = new System.Drawing.Size(247, 40);
            this.txb_TenDangNhap.Name = "txb_TenDangNhap";
            this.txb_TenDangNhap.Size = new System.Drawing.Size(286, 34);
            this.txb_TenDangNhap.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên đăng nhập";
            // 
            // txb_MatKhau
            // 
            this.txb_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_MatKhau.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MatKhau.Location = new System.Drawing.Point(24, 187);
            this.txb_MatKhau.MinimumSize = new System.Drawing.Size(247, 40);
            this.txb_MatKhau.Name = "txb_MatKhau";
            this.txb_MatKhau.Size = new System.Drawing.Size(247, 34);
            this.txb_MatKhau.TabIndex = 6;
            this.txb_MatKhau.UseSystemPasswordChar = true;
            this.txb_MatKhau.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mật khẩu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_ThongBaoTDN);
            this.groupBox1.Controls.Add(this.lbl_ThongBao);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.lbl_QuenMK);
            this.groupBox1.Controls.Add(this.btn_eyePass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_DangNhap);
            this.groupBox1.Controls.Add(this.txb_MatKhau);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txb_TenDangNhap);
            this.groupBox1.Location = new System.Drawing.Point(162, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 422);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lbl_ThongBaoTDN
            // 
            this.lbl_ThongBaoTDN.AutoSize = true;
            this.lbl_ThongBaoTDN.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongBaoTDN.Location = new System.Drawing.Point(24, 119);
            this.lbl_ThongBaoTDN.Name = "lbl_ThongBaoTDN";
            this.lbl_ThongBaoTDN.Size = new System.Drawing.Size(86, 19);
            this.lbl_ThongBaoTDN.TabIndex = 12;
            this.lbl_ThongBaoTDN.Text = "Thông báo";
            // 
            // lbl_ThongBao
            // 
            this.lbl_ThongBao.AutoSize = true;
            this.lbl_ThongBao.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongBao.Location = new System.Drawing.Point(24, 241);
            this.lbl_ThongBao.Name = "lbl_ThongBao";
            this.lbl_ThongBao.Size = new System.Drawing.Size(86, 19);
            this.lbl_ThongBao.TabIndex = 11;
            this.lbl_ThongBao.Text = "Thông báo";
            // 
            // lbl_QuenMK
            // 
            this.lbl_QuenMK.AutoSize = true;
            this.lbl_QuenMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_QuenMK.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuenMK.Location = new System.Drawing.Point(220, 241);
            this.lbl_QuenMK.Name = "lbl_QuenMK";
            this.lbl_QuenMK.Size = new System.Drawing.Size(128, 19);
            this.lbl_QuenMK.TabIndex = 9;
            this.lbl_QuenMK.Text = "Quên mật khẩu?";
            this.lbl_QuenMK.Click += new System.EventHandler(this.lbl_QuenMK_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_DangNhap.Location = new System.Drawing.Point(118, 277);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(134, 70);
            this.btn_DangNhap.TabIndex = 2;
            this.btn_DangNhap.Text = "Đăng  Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.Image = global::GUI.Properties.Resources.c;
            this.btn_Thoat.Location = new System.Drawing.Point(133, 371);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(100, 45);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_eyePass
            // 
            this.btn_eyePass.BackColor = System.Drawing.Color.White;
            this.btn_eyePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eyePass.Location = new System.Drawing.Point(274, 190);
            this.btn_eyePass.Name = "btn_eyePass";
            this.btn_eyePass.Size = new System.Drawing.Size(33, 29);
            this.btn_eyePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_eyePass.TabIndex = 8;
            this.btn_eyePass.TabStop = false;
            this.btn_eyePass.Click += new System.EventHandler(this.btn_eyePass_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(295, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 136);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(722, 616);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FDangNhap";
            this.Text = "Đăng nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FDangNhap_FormClosed);
            this.Load += new System.EventHandler(this.FDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eyePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txb_TenDangNhap;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_MatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox btn_eyePass;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lbl_QuenMK;
        private System.Windows.Forms.Label lbl_ThongBaoTDN;
        private System.Windows.Forms.Label lbl_ThongBao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}