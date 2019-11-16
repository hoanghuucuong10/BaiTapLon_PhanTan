using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanDia.ServiceReference1;

namespace QuanLyBanDia
{
    public partial class FormTrangChu : Form
    {
        private eNhanVien nhanVien;
        private FormDangNhap frm;
        public FormTrangChu(eNhanVien nv, FormDangNhap frm)
        {
            InitializeComponent();
            this.nhanVien = nv;
            this.frm = frm;
            loadForm();
        }
        public void loadForm()
        {
            if (this.nhanVien.loaiTK.Trim() == "E")
            {
                //khóa mấy chức năng ko xài được
                mnQuanLyTaiKhoan.Enabled = false;
            }
        }
        #region NguoiDung
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }
        private void mnThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            FormThongTinTaiKhoan frm = new FormThongTinTaiKhoan(nhanVien);
            frm.TopLevel = false;
            frm.Visible = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
        }

        private void mnDoiMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void mnDangXuat_Click_1(object sender, EventArgs e)
        {
            this.frm.Visible=true;
            this.Close();
        }

        private void mnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void mnQLDia_Click(object sender, EventArgs e)
        {
            FormQuanLyDia frm = new FormQuanLyDia();
            frm.TopLevel = false;
            frm.Visible = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
        }
        #region LapHoaDon
        private void mnLapHD_Click(object sender, EventArgs e)
        {
            FormLapHoaDon frm = new FormLapHoaDon(nhanVien);
            frm.TopLevel = false;
            frm.Visible = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);

        }
        #endregion

        private void mnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            FormQuanLyTaiKhoan frm = new FormQuanLyTaiKhoan();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.XemThongTin();
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
        }
        #region ThongKe
        private void mnThongKeHoaDon_Click(object sender, EventArgs e)
        {
            
        }

        private void mnThongKeDia_Click(object sender, EventArgs e)
        {

        }

        #endregion


    }
}
