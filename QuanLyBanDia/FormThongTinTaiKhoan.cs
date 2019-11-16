using QuanLyBanDia.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            int kt = 0;
            #region Kiểm tra dữ liệu nhập
            //MatKhau
            if (string.IsNullOrEmpty(tbMK.Text))
            {
                err.SetError(tbMK, "Không được để trống");
            }
            else
            {
                if (!Regex.IsMatch(tbMK.Text, @"^[0-9]+"))
                {
                    err.SetError(tbMK, "Mật khẩu không hợp lệ");
                }
                else
                {
                    err.SetError(tbMK, "");
                    kt++;
                }
            }
            //Tên
            if (string.IsNullOrEmpty(tbTen.Text))
            {
                err.SetError(tbTen, "Không được để trống");
            }
            else
            {
                if (!Regex.IsMatch(tbTen.Text, @"^[A-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ][a-zàáâãèéếêìíòóôõùúăđĩũơưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ]*(\s[A-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ][a-zàáâãèéếêìíòóôõùúăđĩũơưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ]*)+$"))
                {
                    err.SetError(tbTen, "Tên không hợp lệ");
                }
                else
                {
                    err.SetError(tbTen, "");
                    kt++;
                }
            }

            //Phone
            if (string.IsNullOrEmpty(tbPhone.Text))
            {

                err.SetError(tbPhone, "Không được để trống");
            }
            else
            {
                if (!Regex.IsMatch(tbPhone.Text, @"^[0][1-9][0-9]+$"))
                {
                    err.SetError(tbPhone, "Số điện thoại không hợp lệ");
                }
                else
                {
                    err.SetError(tbPhone, "");
                    kt++;
                }
            }

            //email
            if (string.IsNullOrEmpty(tbMail.Text))
            {
                err.SetError(tbMail, "Không được để trống");
            }
            else
            {
                if (!Regex.IsMatch(tbMail.Text, @"^([a-z0-9_\.-]+)@([\da-z\.-]+)\.([a-z\.]{2,6})$"))
                {

                    err.SetError(tbMail, "Email không hợp lệ");
                }
                else
                {
                    err.SetError(tbMail, "");
                    kt++;
                }
            }
            #endregion
            if (kt == 4)
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
                if (t == true)
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
}
