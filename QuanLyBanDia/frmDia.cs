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
using QuanLyBanDia.ServiceReference1;

namespace QuanLyBanDia
{
    public partial class frmDia : Form
    {
        Service1Client ser;
        public frmDia()
        {
            InitializeComponent();
            ser = new Service1Client();
            LoadDatagrib((List<eDia>)ser.GetAllDia("", "", ""));
        }
        public void LoadDatagrib(List<eDia> lst)
        {
            eDiaBindingSource.DataSource = lst;
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
