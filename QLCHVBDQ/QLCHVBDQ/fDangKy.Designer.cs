﻿namespace QLCHVBDQ
{
    partial class fDangKy
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
            this.DangNhap = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.textTenTK = new System.Windows.Forms.TextBox();
            this.textNhapLaiMK = new System.Windows.Forms.TextBox();
            this.textSDT = new System.Windows.Forms.TextBox();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.textNgaySinh = new System.Windows.Forms.Label();
            this.comBoxGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.picBoxBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // DangNhap
            // 
            this.DangNhap.AutoSize = true;
            this.DangNhap.Font = new System.Drawing.Font("Montserrat Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhap.Location = new System.Drawing.Point(855, 65);
            this.DangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(189, 51);
            this.DangNhap.TabIndex = 5;
            this.DangNhap.Text = "Đăng ký";
            this.DangNhap.Click += new System.EventHandler(this.DangNhap_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.AutoSize = true;
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(149)))));
            this.btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(863, 614);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(647, 60);
            this.btnDangKy.TabIndex = 8;
            this.btnDangKy.Text = "ĐĂNG KÝ";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // Email
            // 
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Email.Location = new System.Drawing.Point(863, 148);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(647, 48);
            this.Email.TabIndex = 6;
            this.Email.TabStop = false;
            this.Email.Text = "Email";
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            this.Email.Enter += new System.EventHandler(this.Email_Enter);
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.password.Location = new System.Drawing.Point(863, 452);
            this.password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(647, 48);
            this.password.TabIndex = 7;
            this.password.TabStop = false;
            this.password.Text = "Mật khẩu";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // textTenTK
            // 
            this.textTenTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTenTK.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenTK.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textTenTK.Location = new System.Drawing.Point(863, 299);
            this.textTenTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textTenTK.Name = "textTenTK";
            this.textTenTK.Size = new System.Drawing.Size(647, 48);
            this.textTenTK.TabIndex = 9;
            this.textTenTK.TabStop = false;
            this.textTenTK.Text = "Tên tài khoản";
            this.textTenTK.TextChanged += new System.EventHandler(this.textTenTK_TextChanged);
            this.textTenTK.Enter += new System.EventHandler(this.textTenTK_Enter);
            this.textTenTK.Leave += new System.EventHandler(this.textTenTK_Leave);
            // 
            // textNhapLaiMK
            // 
            this.textNhapLaiMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNhapLaiMK.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNhapLaiMK.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textNhapLaiMK.Location = new System.Drawing.Point(863, 528);
            this.textNhapLaiMK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNhapLaiMK.Name = "textNhapLaiMK";
            this.textNhapLaiMK.Size = new System.Drawing.Size(647, 48);
            this.textNhapLaiMK.TabIndex = 10;
            this.textNhapLaiMK.TabStop = false;
            this.textNhapLaiMK.Text = "Nhập lại mật khẩu";
            this.textNhapLaiMK.TextChanged += new System.EventHandler(this.textNhapLaiMK_TextChanged);
            this.textNhapLaiMK.Enter += new System.EventHandler(this.textNhapLaiMK_Enter);
            this.textNhapLaiMK.Leave += new System.EventHandler(this.textNhapLaiMK_Leave);
            // 
            // textSDT
            // 
            this.textSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSDT.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSDT.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textSDT.Location = new System.Drawing.Point(863, 224);
            this.textSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSDT.Name = "textSDT";
            this.textSDT.Size = new System.Drawing.Size(647, 48);
            this.textSDT.TabIndex = 11;
            this.textSDT.TabStop = false;
            this.textSDT.Text = "Số điện thoại";
            this.textSDT.TextChanged += new System.EventHandler(this.textSDT_TextChanged);
            this.textSDT.Enter += new System.EventHandler(this.textSDT_Enter);
            this.textSDT.Leave += new System.EventHandler(this.textSDT_Leave);
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaySinh.Location = new System.Drawing.Point(1054, 381);
            this.dateNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateNgaySinh.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(235, 44);
            this.dateNgaySinh.TabIndex = 12;
            this.dateNgaySinh.ValueChanged += new System.EventHandler(this.dateNgaySinh_ValueChanged);
            // 
            // textNgaySinh
            // 
            this.textNgaySinh.AutoSize = true;
            this.textNgaySinh.BackColor = System.Drawing.SystemColors.Window;
            this.textNgaySinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNgaySinh.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNgaySinh.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textNgaySinh.Location = new System.Drawing.Point(861, 375);
            this.textNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textNgaySinh.Name = "textNgaySinh";
            this.textNgaySinh.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.textNgaySinh.Size = new System.Drawing.Size(170, 47);
            this.textNgaySinh.TabIndex = 13;
            this.textNgaySinh.Text = "Ngày sinh";
            this.textNgaySinh.Click += new System.EventHandler(this.textNgaySinh_Click);
            // 
            // comBoxGioiTinh
            // 
            this.comBoxGioiTinh.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxGioiTinh.FormattingEnabled = true;
            this.comBoxGioiTinh.ItemHeight = 41;
            this.comBoxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comBoxGioiTinh.Location = new System.Drawing.Point(1325, 376);
            this.comBoxGioiTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comBoxGioiTinh.Name = "comBoxGioiTinh";
            this.comBoxGioiTinh.Size = new System.Drawing.Size(185, 49);
            this.comBoxGioiTinh.TabIndex = 14;
            this.comBoxGioiTinh.Text = "Giới tính";
            this.comBoxGioiTinh.SelectedIndexChanged += new System.EventHandler(this.comBoxGioiTinh_SelectedIndexChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Montserrat ExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(863, 708);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(203, 57);
            this.btnDangNhap.TabIndex = 15;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // picBoxBackground
            // 
            this.picBoxBackground.Image = global::QLCHVBDQ.Properties.Resources._438927782_837074425123806_4059625218187402943_n;
            this.picBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.picBoxBackground.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxBackground.Name = "picBoxBackground";
            this.picBoxBackground.Size = new System.Drawing.Size(775, 850);
            this.picBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBackground.TabIndex = 2;
            this.picBoxBackground.TabStop = false;
            // 
            // fDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1579, 850);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.comBoxGioiTinh);
            this.Controls.Add(this.textNgaySinh);
            this.Controls.Add(this.dateNgaySinh);
            this.Controls.Add(this.textSDT);
            this.Controls.Add(this.textNhapLaiMK);
            this.Controls.Add(this.textTenTK);
            this.Controls.Add(this.DangNhap);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.picBoxBackground);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1727, 1066);
            this.Name = "fDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDangKy";
            this.Load += new System.EventHandler(this.fDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxBackground;
        private System.Windows.Forms.Label DangNhap;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox textTenTK;
        private System.Windows.Forms.TextBox textNhapLaiMK;
        private System.Windows.Forms.TextBox textSDT;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.Label textNgaySinh;
        private System.Windows.Forms.ComboBox comBoxGioiTinh;
        private System.Windows.Forms.Button btnDangNhap;
    }
}