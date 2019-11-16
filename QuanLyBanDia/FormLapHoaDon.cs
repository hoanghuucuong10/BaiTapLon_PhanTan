using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
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
            LoadDatagrib(ser.SearchDia("", "", "").ToList());
            eChiTietHoaDonBindingSource.DataSource = lstChiTiet;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvDsDia.SelectedRows.Count > 0 && nudSoLuong.Value > 0)
            {
                eDia dia = dgvDsDia.Rows[dgvDsDia.CurrentRow.Index].DataBoundItem as eDia;
                eChiTietHoaDon newItem = new eChiTietHoaDon();
                newItem.maDia = dia.maDia;
                newItem.soLuong = (int)nudSoLuong.Value;
                newItem.thanhTien = dia.donGia;
                newItem.tenDia = dia.tenDia;
                int index = -1;
                foreach (eChiTietHoaDon item in lstChiTiet)
                {
                    index++;
                    if (item.maDia == newItem.maDia)
                    {
                        lstChiTiet[index].soLuong += (int)nudSoLuong.Value;
                        lstChiTiet[index].thanhTien = lstChiTiet[index].soLuong * dia.donGia;
                        eChiTietHoaDonBindingSource.DataSource = lstChiTiet;
                        eChiTietHoaDonBindingSource.ResetBindings(false);
                        dataGridView2.Refresh();
                        return;
                    }
                }
                lstChiTiet.Add(newItem);
                eChiTietHoaDonBindingSource.DataSource = lstChiTiet;
                eChiTietHoaDonBindingSource.ResetBindings(false);
                dataGridView2.Refresh();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0 && nudSoLuong.Value > 0)
            {
                eChiTietHoaDon ct = dataGridView2.Rows[dataGridView2.CurrentRow.Index].DataBoundItem as eChiTietHoaDon;
                int index = -1;
                bool isDelete = false;
                foreach ( eChiTietHoaDon item in lstChiTiet)
                {
                    index++;
                    if (item.maDia == ct.maDia)
                    {
                        if (item.soLuong - (int)nudSoLuong.Value < 1)
                        {
                            isDelete = true;
                        }
                        else
                        {
                            int soluong = lstChiTiet[index].soLuong;
                            lstChiTiet[index].soLuong -= (int)nudSoLuong.Value;
                            lstChiTiet[index].thanhTien = (lstChiTiet[index].thanhTien / soluong) * lstChiTiet[index].soLuong;
                        }
                    }
                }
                if (isDelete)
                {
                    lstChiTiet.RemoveAt(dataGridView2.CurrentRow.Index);
                }
                eChiTietHoaDonBindingSource.DataSource = lstChiTiet;
                eChiTietHoaDonBindingSource.ResetBindings(false);
                dataGridView2.Refresh();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbLoaiHD.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng chọn loại hóa đơn");
                }
                else
                {
                    if (ser.SearchDia("", "", "").ToList()
                        .Any(s => lstChiTiet.Select(a => a.maDia)
                        .Contains(s.maDia)
                        && lstChiTiet.FirstOrDefault(d => d.maDia == s.maDia).soLuong > s.soLuong) && cbLoaiHD.Text == "Bán")
                    {
                        MessageBox.Show("Số lượng đĩa để bán không đủ");
                        return;
                    }
                    hoaDon.loaiHoaDon = cbLoaiHD.Text;
                    hoaDon.ngayLapHD = dateNgayLap.Value.Date;
                    hoaDon.tongTien = lstChiTiet.Sum(x => x.thanhTien);
                    if (ser.AddHoaDon(hoaDon, lstChiTiet.ToArray()))
                    {
                        MessageBox.Show("Lập hóa đơn thành công");
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Lập hóa đơn thất bại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
