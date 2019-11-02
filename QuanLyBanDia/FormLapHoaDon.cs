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
    public partial class FormLapHoaDon : Form
    {
        Service1Client ser = new Service1Client();
        eNhanVien nhanVien;
        eHoaDon hoaDon;
        List<eChiTietHoaDon> lstChiTiet;
        public FormLapHoaDon(eNhanVien x)
        {
            InitializeComponent();
            this.nhanVien = x;
            List<eTheLoai> ls = ser.GetAllTheLoai().ToList();
            cbTheLoaiSearch.Items.Add("");
            foreach (eTheLoai s in ls)
            {
                cbTheLoaiSearch.Items.Add(s.tenTheLoai.Trim());
            }

            Reset();
        }
        public void Reset()
        {
            hoaDon = new eHoaDon();
            hoaDon.maHoaDon = (ser.GetAllHoaDon().Max(t => t.maHoaDon) + 1);
            hoaDon.maNhanVien = nhanVien.maNhanVien;
            lstChiTiet = new List<eChiTietHoaDon>();
            tbMaHD.Text = hoaDon.maHoaDon.ToString();
            dateNgayLap.Value = DateTime.Now;
            LoadDatagrib(ser.SearchDia("","","").ToList());

        }
        public void LoadDatagrib(List<eDia> lst)
        {
            eDiaBindingSource.DataSource = lst;
        }
        //search
        private void button1_Click(object sender, EventArgs e)
        {
            LoadDatagrib(ser.SearchDia(tbMaDiaSearch.Text.Trim(), tbTenDiaSearch.Text.Trim(), cbTheLoaiSearch.Text.ToString().Trim()).ToList());
        }
    }
}
