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
using System.IO;

namespace QuanLyBanDia
{
    public partial class FormQuanLyDia : Form
    {
        Service1Client ser;
        TreeNode nGoc;
        string filePath = "";
        byte[] byteImage = { };
        int k = 0;
        public FormQuanLyDia()
        {

            InitializeComponent();
            byteImage = converterDemo(pictureBox1.Image);
            nGoc = new TreeNode();
            ser = new Service1Client();

            LoadDatagrib((List<eDia>)ser.GetAllDia("", "").ToList());

            nGoc = new TreeNode("Danh Sách Thể Loại");
            treeView1.Nodes.Add(nGoc);
            LoadTree(ser.GetAllTheLoai().ToList());
            treeView1.ImageIndex = 0;
            treeView1.SelectedImageIndex = 1;

            cbTheLoai.DataSource = ser.GetAllTheLoai().ToList();
            cbTheLoai.DisplayMember = "tenTheLoai";
            cbTheLoai.ValueMember = "maTheLoai";

            tbxDonGia.Enabled = false;
            tbxID.Enabled = false;
            tbxTenDia.Enabled = false;
            cbTheLoai.Enabled = false;
            numSL.Enabled = false;
            ClearTB();
        }
        public void LoadDatagrib(List<eDia> lst)
        {
            eDiaBindingSource.DataSource = lst;
        }
        public void LoadTree(List<eTheLoai> lst)
        {
            nGoc.Nodes.Clear();

            foreach (eTheLoai tl in lst)
            {
                TreeNode n = new TreeNode(tl.tenTheLoai);
                n.Tag = tl.maTheLoai;
                nGoc.Nodes.Add(n);
            }
            treeView1.ExpandAll();
        }

        private byte[] converImgToByte(string fileName)
        {
            FileStream fs;
            byte[] picbyte;
            try
            {

                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                picbyte = new byte[fs.Length];
                fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                return picbyte;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        private Image ByteToImg(string byteString)
        {
            try
            {
                byte[] imgBytes = Convert.FromBase64String(byteString);
                MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
                ms.Write(imgBytes, 0, imgBytes.Length);
                Image image = Image.FromStream(ms, true);
                return image;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filePath = openFile.FileName;
                string s = Convert.ToBase64String(converImgToByte(filePath));
                byteImage = Convert.FromBase64String(s);
                pictureBox1.Image = ByteToImg(s);
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.Level == 1)
                {
                    LoadDSDia();
                }
            }
            ClearTB();
        }
        void LoadDSDia()
        {
            int maTL = -1;
            maTL = (int)treeView1.SelectedNode.Tag;
            List<eDia> dsDia = ser.GetAllDiaTheLoai(maTL).ToList();
            LoadDatagrib(dsDia);
        }
        //Btn Search
        private void button1_Click(object sender, EventArgs e)
        {
            LoadDatagrib((List<eDia>)ser.GetAllDia(tbMaDiaSearch.Text.Trim(), tbTenDiaSearch.Text.Trim()).ToList());
        }

        //Load dữ liệu lên textbox khi chọn trên datagrib
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadFormTT();
        }
        public void LoadFormTT()
        {
            if (k == 2)
                return;
            int rowSelected = 0;
            try
            {
                rowSelected = dataGridView1.CurrentRow.Index;
            }
            catch (Exception ex)
            {
                return;
            }
            try
            {
                eDia dia = ser.GetDiaByID(int.Parse(dataGridView1.Rows[rowSelected].Cells[0].Value.ToString().Trim()));
                tbxID.Text = dia.maDia.ToString();
                tbxTenDia.Text = dia.tenDia;
                tbxDonGia.Text = dia.donGia.ToString();
                numSL.Value = dia.soLuong;
                cbTheLoai.SelectedValue = dia.maTheLoai;
                pictureBox1.Image = ByteToImg(Convert.ToBase64String(dia.HinhAnh));
            }
            catch (Exception e)
            {

            }

        }
        public void ClearTB()
        {
            tbxID.Text = "";
            tbxTenDia.Text = "";
            tbxDonGia.Text = "";
            numSL.Value = 0;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            eDia d = new eDia();
            d.maDia = int.Parse(tbxID.Text.Trim());
            d.tenDia = tbxTenDia.Text.Trim();
            d.maTheLoai = int.Parse(cbTheLoai.SelectedValue.ToString().Trim());
            d.tenTheLoai = cbTheLoai.SelectedText.Trim();
            d.soLuong = int.Parse(numSL.Value.ToString().Trim());
            d.donGia = double.Parse(tbxDonGia.Text.Trim());
            d.HinhAnh = converterDemo(pictureBox1.Image);
            if (k == 2)//them
            {
                bool r = ser.AddDia(d);
                if (r == true)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadDatagrib((List<eDia>)ser.GetAllDia("", "").ToList());
                    pictureBox1.Image = ByteToImg(Convert.ToBase64String(byteImage));
                    ClearTB();

                    tbxID.Text = (ser.GetAllDia("", "").Max(x => x.maDia) + 1).ToString();
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else if (k == 1)//sua
            {
                bool r = ser.EditDia(d);

                if (r == true)
                {
                    MessageBox.Show("Sửa thành công");
                    LoadDatagrib((List<eDia>)ser.GetAllDia("", "").ToList());
                }
                else
                    MessageBox.Show("Sửa thất bại");
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            k = 0;
            btnHuy.Visible = false;
            btnLuu.Visible = false;
            btnSua.Visible = true;
            btnThem.Visible = true;

            tbxDonGia.Enabled = false;
            tbxID.Enabled = false;
            tbxTenDia.Enabled = false;
            cbTheLoai.Enabled = false;
            numSL.Enabled = false;

            ClearTB();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            k = 1;
            btnHuy.Visible = true;
            btnLuu.Visible = true;
            btnSua.Visible = false;
            btnThem.Visible = false;

            tbxDonGia.Enabled = true;
            tbxID.Enabled = true;
            tbxTenDia.Enabled = true;
            cbTheLoai.Enabled = true;
            numSL.Enabled = true;

            LoadFormTT();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            k = 2;
            btnHuy.Visible = true;
            btnLuu.Visible = true;
            btnSua.Visible = false;
            btnThem.Visible = false;

            tbxDonGia.Enabled = true;
            tbxID.Enabled = true;
            tbxTenDia.Enabled = true;
            cbTheLoai.Enabled = true;
            numSL.Enabled = true;

            pictureBox1.Image = ByteToImg(Convert.ToBase64String(byteImage));
            ClearTB();

            tbxID.Text = (ser.GetAllDia("", "").Max(x => x.maDia) + 1).ToString();

        }
    }
}
