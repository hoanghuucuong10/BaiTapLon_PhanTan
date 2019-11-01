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
    public partial class frmMain : Form
    {
        private eNhanVien nhanVien;
        private frmLogin frm;
        public frmMain(eNhanVien nv, frmLogin frm)
        {
            InitializeComponent();
            this.nhanVien = nv;
            this.frm = frm;
            loadForm();
        }
        public void loadForm()
        {
            if(this.nhanVien.loaiTK.Trim()=="E")
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

        }

        private void mnDoiMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void mnDangXuat_Click_1(object sender, EventArgs e)
        {
            this.frm.Show();
            this.Close();
        }

        private void mnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void mnQLDia_Click(object sender, EventArgs e)
        {
            frmDia frm = new frmDia();
            frm.TopLevel = false;
            frm.Visible = true;
            panel2.Controls.Add(frm);
        }
        #region LapHoaDon
        private void mnHoaDonBanDia_Click(object sender, EventArgs e)
        {

        }

        private void mnHoaDonNhapDia_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void mnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {

        }
        #region ThongKe
        private void mnThongKeHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void mnThongKeDia_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
