namespace QuanLyBanDia
{
    partial class FormTrangChu
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
            this.mnNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQLDia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLapHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongKeHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongKeDia = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel1.Size = new System.Drawing.Size(1040, 68);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnNguoiDung,
            this.mnQLDia,
            this.mnLapHD,
            this.mnQuanLyTaiKhoan,
            this.mnThongKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1040, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnNguoiDung
            // 
            this.mnNguoiDung.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnThongTinTaiKhoan,
            this.mnDangXuat,
            this.mnThoat});
            this.mnNguoiDung.ForeColor = System.Drawing.Color.Blue;
            this.mnNguoiDung.Name = "mnNguoiDung";
            this.mnNguoiDung.Size = new System.Drawing.Size(102, 23);
            this.mnNguoiDung.Text = "Người Dùng";
            // 
            // mnThongTinTaiKhoan
            // 
            this.mnThongTinTaiKhoan.Name = "mnThongTinTaiKhoan";
            this.mnThongTinTaiKhoan.Size = new System.Drawing.Size(213, 24);
            this.mnThongTinTaiKhoan.Text = "Thông Tin Tài Khoản";
            this.mnThongTinTaiKhoan.Click += new System.EventHandler(this.mnThongTinTaiKhoan_Click);
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
            // mnLapHD
            // 
            this.mnLapHD.ForeColor = System.Drawing.Color.Blue;
            this.mnLapHD.Name = "mnLapHD";
            this.mnLapHD.Size = new System.Drawing.Size(108, 23);
            this.mnLapHD.Text = "Lập Hóa Đơn";
            this.mnLapHD.Click += new System.EventHandler(this.mnLapHD_Click);
            // 
            // mnQuanLyTaiKhoan
            // 
            this.mnQuanLyTaiKhoan.ForeColor = System.Drawing.Color.Blue;
            this.mnQuanLyTaiKhoan.Name = "mnQuanLyTaiKhoan";
            this.mnQuanLyTaiKhoan.Size = new System.Drawing.Size(144, 23);
            this.mnQuanLyTaiKhoan.Text = "Quản Lý Tài Khoản";
            this.mnQuanLyTaiKhoan.Click += new System.EventHandler(this.mnQuanLyTaiKhoan_Click);
            // 
            // mnThongKe
            // 
            this.mnThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnThongKeHoaDon,
            this.mnThongKeDia});
            this.mnThongKe.ForeColor = System.Drawing.Color.Blue;
            this.mnThongKe.Name = "mnThongKe";
            this.mnThongKe.Size = new System.Drawing.Size(84, 23);
            this.mnThongKe.Text = "Thống Kê";
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
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1040, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phần Mềm Quản Lý Cửa Hàng Bán Đĩa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1040, 1);
            this.label2.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 510);
            this.panel2.TabIndex = 4;
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanDia.Properties.Resources.istockphoto_995719694_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormTrangChu";
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
        private System.Windows.Forms.ToolStripMenuItem mnNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem mnThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnThoat;
        private System.Windows.Forms.ToolStripMenuItem mnQLDia;
        private System.Windows.Forms.ToolStripMenuItem mnLapHD;
        private System.Windows.Forms.ToolStripMenuItem mnQuanLyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnThongKeHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnThongKeDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}