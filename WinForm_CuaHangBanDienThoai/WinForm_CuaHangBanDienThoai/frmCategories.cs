using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_CuaHangBanDienThoai
{
    public partial class frmCategories : Form
    {
        CategoriesBLL categoriesBLL;
        List<tb_ProductCategory> lst;
        List<CategoriesDTO> categoriesList;
        public frmCategories()
        {
            InitializeComponent();
            categoriesBLL = new CategoriesBLL();
            LoadData();
            string duongDanUngDung = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(duongDanUngDung, @"D:\cuahangdienthoai\Uploads\Uploads\images\ProductCategory\Icon\null.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.ImageLocation = imagePath;
        }
        public void LoadData()
        {
            categoriesList = categoriesBLL.getDanhSachDanhMuc();
            tblCategories.DataSource = categoriesList;
            tblCategories.Columns[0].HeaderText = "Mã Danh Mục";
            tblCategories.Columns[1].HeaderText = "Tên Danh Mục";
            tblCategories.Columns[2].HeaderText = "Đường dẫn ";


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Visible = false;
                Program.mainForm = new frmMain();
                Program.mainForm.Show();
            }
        }

        private void tblCategories_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = tblCategories.SelectedRows[0];
            TenDM.Text = selectedRow.Cells[1].Value.ToString();
            HinhDM.Text = selectedRow.Cells[2].Value.ToString();
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            TenDM.Enabled = true;
            HinhDM.Enabled = true;

            string linksanpham = selectedRow.Cells[2].Value.ToString();
            string duongDanUngDung = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(duongDanUngDung, @"\Uploads\Uploads\images\ProductCategory\Icon" + linksanpham + @"");
            if (System.IO.File.Exists(imagePath))
            {
                pictureBox1.ImageLocation = imagePath;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
                MessageBox.Show("Hình ảnh không tồn tại.");
        }
    }
}
