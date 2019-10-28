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
    public partial class frmLogin : Form
    {
        Service1Client ser;
        public frmLogin()
        {
            InitializeComponent();
            ser = new Service1Client();
        }

        private void tbxPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            eNhanVien nv = ser.Login(tbxUserName.Text.Trim(), tbxPW.Text.Trim());
            if(nv == null)
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
            else
            {
                frmMain frm = new frmMain(nv,this);
                frm.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
