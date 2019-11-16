namespace QuanLyBanDia
{
    partial class FormLapHoaDon
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.eChiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTheLoaiSearch = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDsDia = new System.Windows.Forms.DataGridView();
            this.maDiaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDiaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTheLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTheLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhAnhDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.eDiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbTenDiaSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaDiaSearch = new System.Windows.Forms.TextBox();
            this.tenDiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbLoaiHD = new System.Windows.Forms.ComboBox();
            this.dateNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eChiTietHoaDonBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDiaBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = global::QuanLyBanDia.Properties.Resources.istockphoto_995719694_612x612;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 628);
            this.panel1.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(705, 106);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(705, 51);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.Image = global::QuanLyBanDia.Properties.Resources.clear;
            this.btnHuy.Location = new System.Drawing.Point(463, 480);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 57);
            this.btnHuy.TabIndex = 29;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Image = global::QuanLyBanDia.Properties.Resources.check_symbol;
            this.btnSave.Location = new System.Drawing.Point(356, 480);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 57);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbLoaiHD);
            this.groupBox1.Controls.Add(this.dateNgayLap);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbMaHD);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.lbTongTien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(808, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(563, 597);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDiaDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.eChiTietHoaDonBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(555, 344);
            this.dataGridView2.TabIndex = 8;
            // 
            // eChiTietHoaDonBindingSource
            // 
            this.eChiTietHoaDonBindingSource.DataSource = typeof(QuanLyBanDia.ServiceReference1.eChiTietHoaDon);
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(409, 405);
            this.lbTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(0, 17);
            this.lbTongTien.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 405);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tổng tiền:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cbTheLoaiSearch);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dgvDsDia);
            this.groupBox2.Controls.Add(this.tbTenDiaSearch);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbMaDiaSearch);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(676, 598);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Đĩa";
            // 
            // cbTheLoaiSearch
            // 
            this.cbTheLoaiSearch.FormattingEnabled = true;
            this.cbTheLoaiSearch.Location = new System.Drawing.Point(491, 41);
            this.cbTheLoaiSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cbTheLoaiSearch.Name = "cbTheLoaiSearch";
            this.cbTheLoaiSearch.Size = new System.Drawing.Size(135, 24);
            this.cbTheLoaiSearch.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::QuanLyBanDia.Properties.Resources.search__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(635, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 30);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDsDia
            // 
            this.dgvDsDia.AutoGenerateColumns = false;
            this.dgvDsDia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDsDia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDsDia.BackgroundColor = System.Drawing.Color.White;
            this.dgvDsDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDiaDataGridViewTextBoxColumn1,
            this.tenDiaDataGridViewTextBoxColumn1,
            this.tenTheLoaiDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn1,
            this.donGiaDataGridViewTextBoxColumn,
            this.maTheLoaiDataGridViewTextBoxColumn,
            this.hinhAnhDataGridViewImageColumn});
            this.dgvDsDia.DataSource = this.eDiaBindingSource;
            this.dgvDsDia.Location = new System.Drawing.Point(12, 87);
            this.dgvDsDia.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDsDia.MultiSelect = false;
            this.dgvDsDia.Name = "dgvDsDia";
            this.dgvDsDia.ReadOnly = true;
            this.dgvDsDia.RowHeadersVisible = false;
            this.dgvDsDia.RowHeadersWidth = 51;
            this.dgvDsDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDsDia.Size = new System.Drawing.Size(615, 500);
            this.dgvDsDia.TabIndex = 8;
            // 
            // maDiaDataGridViewTextBoxColumn1
            // 
            this.maDiaDataGridViewTextBoxColumn1.DataPropertyName = "maDia";
            this.maDiaDataGridViewTextBoxColumn1.HeaderText = "Mã Đĩa";
            this.maDiaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.maDiaDataGridViewTextBoxColumn1.Name = "maDiaDataGridViewTextBoxColumn1";
            this.maDiaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.maDiaDataGridViewTextBoxColumn1.Width = 81;
            // 
            // tenDiaDataGridViewTextBoxColumn1
            // 
            this.tenDiaDataGridViewTextBoxColumn1.DataPropertyName = "tenDia";
            this.tenDiaDataGridViewTextBoxColumn1.HeaderText = "Tên Đĩa";
            this.tenDiaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tenDiaDataGridViewTextBoxColumn1.Name = "tenDiaDataGridViewTextBoxColumn1";
            this.tenDiaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tenDiaDataGridViewTextBoxColumn1.Width = 87;
            // 
            // tenTheLoaiDataGridViewTextBoxColumn
            // 
            this.tenTheLoaiDataGridViewTextBoxColumn.DataPropertyName = "tenTheLoai";
            this.tenTheLoaiDataGridViewTextBoxColumn.HeaderText = "Thể Loại";
            this.tenTheLoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenTheLoaiDataGridViewTextBoxColumn.Name = "tenTheLoaiDataGridViewTextBoxColumn";
            this.tenTheLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenTheLoaiDataGridViewTextBoxColumn.Width = 93;
            // 
            // soLuongDataGridViewTextBoxColumn1
            // 
            this.soLuongDataGridViewTextBoxColumn1.DataPropertyName = "soLuong";
            this.soLuongDataGridViewTextBoxColumn1.HeaderText = "Số Lượng";
            this.soLuongDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn1.Name = "soLuongDataGridViewTextBoxColumn1";
            this.soLuongDataGridViewTextBoxColumn1.ReadOnly = true;
            this.soLuongDataGridViewTextBoxColumn1.Width = 98;
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "donGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "Đơn Giá";
            this.donGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            this.donGiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.donGiaDataGridViewTextBoxColumn.Width = 89;
            // 
            // maTheLoaiDataGridViewTextBoxColumn
            // 
            this.maTheLoaiDataGridViewTextBoxColumn.DataPropertyName = "maTheLoai";
            this.maTheLoaiDataGridViewTextBoxColumn.HeaderText = "maTheLoai";
            this.maTheLoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maTheLoaiDataGridViewTextBoxColumn.Name = "maTheLoaiDataGridViewTextBoxColumn";
            this.maTheLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.maTheLoaiDataGridViewTextBoxColumn.Visible = false;
            this.maTheLoaiDataGridViewTextBoxColumn.Width = 108;
            // 
            // hinhAnhDataGridViewImageColumn
            // 
            this.hinhAnhDataGridViewImageColumn.DataPropertyName = "HinhAnh";
            this.hinhAnhDataGridViewImageColumn.HeaderText = "HinhAnh";
            this.hinhAnhDataGridViewImageColumn.MinimumWidth = 6;
            this.hinhAnhDataGridViewImageColumn.Name = "hinhAnhDataGridViewImageColumn";
            this.hinhAnhDataGridViewImageColumn.ReadOnly = true;
            this.hinhAnhDataGridViewImageColumn.Visible = false;
            this.hinhAnhDataGridViewImageColumn.Width = 68;
            // 
            // eDiaBindingSource
            // 
            this.eDiaBindingSource.DataSource = typeof(QuanLyBanDia.ServiceReference1.eDia);
            // 
            // tbTenDiaSearch
            // 
            this.tbTenDiaSearch.Location = new System.Drawing.Point(251, 42);
            this.tbTenDiaSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenDiaSearch.Name = "tbTenDiaSearch";
            this.tbTenDiaSearch.Size = new System.Drawing.Size(160, 22);
            this.tbTenDiaSearch.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Thể Loại:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Tên Đĩa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã Đĩa:";
            // 
            // tbMaDiaSearch
            // 
            this.tbMaDiaSearch.Location = new System.Drawing.Point(76, 42);
            this.tbMaDiaSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaDiaSearch.Name = "tbMaDiaSearch";
            this.tbMaDiaSearch.Size = new System.Drawing.Size(100, 22);
            this.tbMaDiaSearch.TabIndex = 15;
            // 
            // tenDiaDataGridViewTextBoxColumn
            // 
            this.tenDiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenDiaDataGridViewTextBoxColumn.DataPropertyName = "tenDia";
            this.tenDiaDataGridViewTextBoxColumn.HeaderText = "Tên Đĩa";
            this.tenDiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDiaDataGridViewTextBoxColumn.Name = "tenDiaDataGridViewTextBoxColumn";
            this.tenDiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "soLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongDataGridViewTextBoxColumn.Width = 98;
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "thanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "Thành Tiền";
            this.thanhTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            this.thanhTienDataGridViewTextBoxColumn.ReadOnly = true;
            this.thanhTienDataGridViewTextBoxColumn.Width = 200;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nudSoLuong);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 100);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 344);
            this.panel3.TabIndex = 15;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(79, 22);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(50, 22);
            this.nudSoLuong.TabIndex = 27;
            // 
            // cbLoaiHD
            // 
            this.cbLoaiHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiHD.FormattingEnabled = true;
            this.cbLoaiHD.Items.AddRange(new object[] {
            "Bán",
            "Nhập"});
            this.cbLoaiHD.Location = new System.Drawing.Point(146, 548);
            this.cbLoaiHD.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiHD.Name = "cbLoaiHD";
            this.cbLoaiHD.Size = new System.Drawing.Size(191, 24);
            this.cbLoaiHD.TabIndex = 26;
            // 
            // dateNgayLap
            // 
            this.dateNgayLap.Enabled = false;
            this.dateNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayLap.Location = new System.Drawing.Point(146, 515);
            this.dateNgayLap.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayLap.Name = "dateNgayLap";
            this.dateNgayLap.Size = new System.Drawing.Size(191, 22);
            this.dateNgayLap.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Chi tiết hóa đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 551);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Loại Hóa Đơn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 520);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ngày Lập Hóa Đơn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 485);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mã Hóa Đơn:";
            // 
            // tbMaHD
            // 
            this.tbMaHD.Location = new System.Drawing.Point(146, 482);
            this.tbMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.ReadOnly = true;
            this.tbMaHD.Size = new System.Drawing.Size(191, 22);
            this.tbMaHD.TabIndex = 24;
            // 
            // FormLapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1387, 628);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLapHoaDon";
            this.Text = "FormLapHoaDon";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eChiTietHoaDonBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDiaBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDsDia;
        private System.Windows.Forms.TextBox tbTenDiaSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaDiaSearch;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbTheLoaiSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource eChiTietHoaDonBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDiaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDiaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTheLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTheLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn hinhAnhDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource eDiaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbLoaiHD;
        private System.Windows.Forms.DateTimePicker dateNgayLap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}