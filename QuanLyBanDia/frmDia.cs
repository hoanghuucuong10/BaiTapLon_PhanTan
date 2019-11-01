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
    public partial class frmDia : Form
    {
        Service1Client ser;
        TreeNode nGoc;
        public frmDia()
        {

            InitializeComponent();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
            int rowSelected = 0;
            try
            {
                rowSelected = dataGridView1.CurrentRow.Index;
            }
            catch (Exception ex)
            {
                return;
            }
            eDia dia = ser.GetDiaByID(dataGridView1.Rows[rowSelected].Cells[0].Value.ToString().Trim());
            tbxID.Text = dia.maDia.ToString();
            tbxTenDia.Text = dia.tenDia;
            tbxDonGia.Text = dia.donGia.ToString();
            numSL.Value = dia.soLuong;
        }
        public void ClearTB()
        {
            tbxID.Text = "";
            tbxTenDia.Text = "";
            tbxDonGia.Text = "";
            numSL.Value = 0;
            
        }

       
    }
}
