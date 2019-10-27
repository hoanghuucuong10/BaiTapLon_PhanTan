using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
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
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }

        private void mnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Close();
        }

        private void mnDanhSachDia_Click(object sender, EventArgs e)
        {

        }
    }
}
