﻿namespace QuanLyBanDia
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bánĐĩaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQLDia = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHóaĐơnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHoaDonBanDia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHoaDonNhapDia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongKeHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongKeDia = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.thểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 99);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bánĐĩaToolStripMenuItem,
            this.thểLoạiToolStripMenuItem,
            this.mnQLDia,
            this.lậpHóaĐơnToolStripMenuItem1,
            this.mnQuanLyTaiKhoan,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1040, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bánĐĩaToolStripMenuItem
            // 
            this.bánĐĩaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnThongTinTaiKhoan,
            this.mnDoiMatKhau,
            this.mnDangXuat,
            this.mnThoat});
            this.bánĐĩaToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.bánĐĩaToolStripMenuItem.Name = "bánĐĩaToolStripMenuItem";
            this.bánĐĩaToolStripMenuItem.Size = new System.Drawing.Size(102, 23);
            this.bánĐĩaToolStripMenuItem.Text = "Người Dùng";
            // 
            // mnThongTinTaiKhoan
            // 
            this.mnThongTinTaiKhoan.Name = "mnThongTinTaiKhoan";
            this.mnThongTinTaiKhoan.Size = new System.Drawing.Size(213, 24);
            this.mnThongTinTaiKhoan.Text = "Thông Tin Tài Khoản";
            this.mnThongTinTaiKhoan.Click += new System.EventHandler(this.mnThongTinTaiKhoan_Click);
            // 
            // mnDoiMatKhau
            // 
            this.mnDoiMatKhau.Name = "mnDoiMatKhau";
            this.mnDoiMatKhau.Size = new System.Drawing.Size(213, 24);
            this.mnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.mnDoiMatKhau.Click += new System.EventHandler(this.mnDoiMatKhau_Click);
            // 
            // mnDangXuat
            // 
            this.mnDangXuat.Name = "mnDangXuat";
            this.mnDangXuat.Size = new System.Drawing.Size(213, 24);
            this.mnDangXuat.Text = "Đăng xuất";
            this.mnDangXuat.Click += new System.EventHandler(this.mnDangXuat_Click_1);
            // 
            // mnThoat
            // 
            this.mnThoat.Name = "mnThoat";
            this.mnThoat.Size = new System.Drawing.Size(213, 24);
            this.mnThoat.Text = "Thoát";
            this.mnThoat.Click += new System.EventHandler(this.mnThoat_Click_1);
            // 
            // mnQLDia
            // 
            this.mnQLDia.ForeColor = System.Drawing.Color.Blue;
            this.mnQLDia.Name = "mnQLDia";
            this.mnQLDia.Size = new System.Drawing.Size(43, 23);
            this.mnQLDia.Text = "Đĩa";
            this.mnQLDia.Click += new System.EventHandler(this.mnQLDia_Click);
            // 
            // lậpHóaĐơnToolStripMenuItem1
            // 
            this.lậpHóaĐơnToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHoaDonBanDia,
            this.mnHoaDonNhapDia});
            this.lậpHóaĐơnToolStripMenuItem1.ForeColor = System.Drawing.Color.Blue;
            this.lậpHóaĐơnToolStripMenuItem1.Name = "lậpHóaĐơnToolStripMenuItem1";
            this.lậpHóaĐơnToolStripMenuItem1.Size = new System.Drawing.Size(108, 23);
            this.lậpHóaĐơnToolStripMenuItem1.Text = "Lập Hóa Đơn";
            // 
            // mnHoaDonBanDia
            // 
            this.mnHoaDonBanDia.Name = "mnHoaDonBanDia";
            this.mnHoaDonBanDia.Size = new System.Drawing.Size(203, 24);
            this.mnHoaDonBanDia.Text = "Hóa Đơn Bán Đĩa";
            this.mnHoaDonBanDia.Click += new System.EventHandler(this.mnHoaDonBanDia_Click);
            // 
            // mnHoaDonNhapDia
            // 
            this.mnHoaDonNhapDia.Name = "mnHoaDonNhapDia";
            this.mnHoaDonNhapDia.Size = new System.Drawing.Size(203, 24);
            this.mnHoaDonNhapDia.Text = "Hóa Đơn Nhập Đĩa";
            this.mnHoaDonNhapDia.Click += new System.EventHandler(this.mnHoaDonNhapDia_Click);
            // 
            // mnQuanLyTaiKhoan
            // 
            this.mnQuanLyTaiKhoan.ForeColor = System.Drawing.Color.Blue;
            this.mnQuanLyTaiKhoan.Name = "mnQuanLyTaiKhoan";
            this.mnQuanLyTaiKhoan.Size = new System.Drawing.Size(144, 23);
            this.mnQuanLyTaiKhoan.Text = "Quản Lý Tài Khoản";
            this.mnQuanLyTaiKhoan.Click += new System.EventHandler(this.mnQuanLyTaiKhoan_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnThongKeHoaDon,
            this.mnThongKeDia});
            this.thốngKêToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // mnThongKeHoaDon
            // 
            this.mnThongKeHoaDon.Name = "mnThongKeHoaDon";
            this.mnThongKeHoaDon.Size = new System.Drawing.Size(137, 24);
            this.mnThongKeHoaDon.Text = "Hóa Đơn";
            this.mnThongKeHoaDon.Click += new System.EventHandler(this.mnThongKeHoaDon_Click);
            // 
            // mnThongKeDia
            // 
            this.mnThongKeDia.Name = "mnThongKeDia";
            this.mnThongKeDia.Size = new System.Drawing.Size(137, 24);
            this.mnThongKeDia.Text = "Đĩa";
            this.mnThongKeDia.Click += new System.EventHandler(this.mnThongKeDia_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("MT Extra", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1040, 99);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phần Mềm Quản Lý Cửa Hàng Bán Đĩa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1040, 1);
            this.label2.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 510);
            this.panel2.TabIndex = 4;
            // 
            // thểLoạiToolStripMenuItem
            // 
            this.thểLoạiToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.thểLoạiToolStripMenuItem.Name = "thểLoạiToolStripMenuItem";
            this.thểLoạiToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.thểLoạiToolStripMenuItem.Text = "Thể Loại";
            this.thểLoạiToolStripMenuItem.Click += new System.EventHandler(this.thểLoạiToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanDia.Properties.Resources.istockphoto_995719694_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 610);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bánĐĩaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnThoat;
        private System.Windows.Forms.ToolStripMenuItem mnQLDia;
        private System.Windows.Forms.ToolStripMenuItem lậpHóaĐơnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnHoaDonBanDia;
        private System.Windows.Forms.ToolStripMenuItem mnHoaDonNhapDia;
        private System.Windows.Forms.ToolStripMenuItem mnQuanLyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnThongKeHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnThongKeDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem thểLoạiToolStripMenuItem;
    }
}