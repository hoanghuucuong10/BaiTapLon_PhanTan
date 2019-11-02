using QuanLyBanDia.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDia
{
    public partial class FormThongTinTaiKhoan : Form
    {
        eNhanVien x;
        Service1Client ser = new Service1Client();
        public FormThongTinTaiKhoan(eNhanVien t)
        {
            InitializeComponent();
            this.x = t;
            LoadTK();
        }
        public void LoadTK()
        {
            tbTen.Text = x.hoTen.Trim();
            tbPhone.Text = x.sDT.Trim();
            tbMK.Text = x.matKhau.Trim();
            tbMail.Text = x.mail.Trim();
        }
        private void btnHide_Click(object sender, EventArgs e)
        {
            tbMK.UseSystemPasswordChar = tbMK.UseSystemPasswordChar == true ? false : true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            eNhanVien m = new eNhanVien();
            m.loaiTK = x.loaiTK.Trim();
            m.maNhanVien = x.maNhanVien;
            m.tenTK = x.tenTK.Trim();

            m.hoTen = tbTen.Text.Trim();
            m.mail = tbMail.Text.Trim();
            m.sDT = tbPhone.Text.Trim();
            m.matKhau = tbMK.Text.Trim();
            bool t = ser.EditNhanVien(m);
            if(t==true)
            {
                MessageBox.Show("Chỉnh sửa thành công");
                this.x = m;
                LoadTK();
            }
            else
            {
                MessageBox.Show("Chỉnh sửa không thành công");
            }
        }

    }
}
