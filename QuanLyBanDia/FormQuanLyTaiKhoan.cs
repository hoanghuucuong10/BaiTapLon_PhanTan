using QuanLyBanDia.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using QuanLyBanDia.ServiceReference1;

namespace QuanLyBanDia
{
    public partial class FormQuanLyTaiKhoan : Form
    {
        int kt = 0;
        Service1Client ser = new Service1Client();
        public FormQuanLyTaiKhoan()
        {
            InitializeComponent();
            ShowDataGrid(ser.GetAllNhanVien("", "").ToList());
            cbLoaiTK.SelectedIndex = 0;
         

        }
        public void XemThongTin()
        {

            groupBox1.Text = "Thông Tin Tài Khoản";
            tbID.ReadOnly = true;
            tbTen.ReadOnly = true;
            tbPhone.ReadOnly = true;
            tbMail.ReadOnly = true;
            tbTenTK.ReadOnly = true;

            btnLuu.Visible = false;
            btnHuy.Visible = false;
            tbMK.ReadOnly = true;
            cbLoaiTK.Enabled = false;


        }

        public void Them()
        {
            groupBox1.Text = "Thêm Tài Khoản";
            tbID.ReadOnly = true;
            tbTen.ReadOnly = false;
            tbPhone.ReadOnly = false;
            tbMail.ReadOnly = false;
            tbTenTK.ReadOnly = true;

            btnLuu.Visible = true;
            btnHuy.Visible = true;
            tbMK.ReadOnly = false;
            cbLoaiTK.Enabled = true;

        }

        public void ChinhSua()
        {
            groupBox1.Text = "Chỉnh Sửa Tài Khoản";
            tbID.ReadOnly = true;
            tbTen.ReadOnly = false;
            tbPhone.ReadOnly = false;
            tbMail.ReadOnly = false;
            tbTenTK.ReadOnly = true;
            cbLoaiTK.Enabled = true;
            btnLuu.Visible = true;
            btnHuy.Visible = true;
            tbMK.ReadOnly = false;

        }

        public void ShowDataGrid(List<eNhanVien>lst)
        {
            eNhanVienBindingSource.DataSource = lst;
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            XemThongTin();
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnHuy.Visible = false;
            btnLuu.Visible = false;
            try
            {

                if (dataGridView1.CurrentRow.Index >= 0)
                {
                    tbID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString().Trim();
                    tbTenTK.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString().Trim();
                    tbTen.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Trim();
                    cbLoaiTK.SelectedItem = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString().Trim();
                    tbPhone.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString().Trim();
                    tbMK.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString().Trim();
                    tbMail.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnHuy.Visible = false;
            btnLuu.Visible = false;
            kt = 0;
            #region Kiểm tra dữ liệu nhập
            //Tên tài khoản
            if (string.IsNullOrEmpty(tbTenTK.Text))
            {
                err.SetError(tbTenTK, "Không được để trống");
            }
            else
            {
                if (!Regex.IsMatch(tbTenTK.Text, @"^[A-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ][a-zàáâãèéếêìíòóôõùúăđĩũơưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ]*(\s[A-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ][a-zàáâãèéếêìíòóôõùúăđĩũơưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ]*)+$"))
                {
                    err.SetError(tbTenTK, "Tên tài khoản không hợp lệ");
                }
                else
                {
                    err.SetError(tbTenTK, "");
                    kt++;
                }
            }
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
            if (kt == 5)
            {
                eNhanVien gv = new eNhanVien();
                gv.maNhanVien =int.Parse( tbID.Text.Trim());
                gv.tenTK = tbTenTK.Text.Trim();
                gv.hoTen = tbTen.Text.Trim();
                gv.mail = tbMail.Text.Trim();
                gv.sDT = tbPhone.Text.Trim();
                gv.matKhau = tbMK.Text.Trim();
                gv.loaiTK = cbLoaiTK.SelectedItem.ToString();

                if (groupBox1.Text == "Thêm Tài Khoản")
                {
                    if (ser.AddNhanVien(gv) == false)
                    {
                        MessageBox.Show("Lưu Thất Bại!!!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thành Công");
                        kt = 0;
                        ShowDataGrid(ser.GetAllNhanVien(tbIDSearch.Text.Trim(), tbTenSearch.Text.Trim()).ToList());
                    }
                }
                else
                {
                    if (ser.EditNhanVien(gv) == false)
                    {
                        MessageBox.Show("Lưu Thất Bại!!!");
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh Sửa Thành Công");
                        kt = 0;
                        ShowDataGrid(ser.GetAllNhanVien(tbIDSearch.Text.Trim(), tbTenSearch.Text.Trim()).ToList());
           
                    }
                }
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Them();
            tbID.Text = (ser.GetAllNhanVien("","").Count()+1).ToString();
            tbTenTK.Text = "";
            tbTen.Text = "";
            tbPhone.Text = "";
            tbMK.Text = "";
            tbMail.Text = "";

            btnThem.Visible = false;
            btnSua.Visible = false;
            btnHuy.Visible = true;
            btnLuu.Visible = true;

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            ChinhSua();
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnHuy.Visible = true;
            btnLuu.Visible = true;
            try
            {

                if (dataGridView1.CurrentRow.Index >= 0)
                {
                    tbID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString().Trim();
                    tbTenTK.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString().Trim();
                    tbTen.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Trim();
                    cbLoaiTK.SelectedItem = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString().Trim();
                    tbPhone.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString().Trim();
                    tbMK.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString().Trim();
                    tbMail.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {

            }
        }

        //search
        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowDataGrid(ser.GetAllNhanVien(tbIDSearch.Text.Trim(), tbTenSearch.Text.Trim()).ToList());
        }

        private void btnHide_Click_1(object sender, EventArgs e)
        {
            tbMK.UseSystemPasswordChar = tbMK.UseSystemPasswordChar == true ? false : true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    tbID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                    tbTenTK.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                    tbTen.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                    cbLoaiTK.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
                    tbPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
                    tbMK.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString().Trim();
                    tbMail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
