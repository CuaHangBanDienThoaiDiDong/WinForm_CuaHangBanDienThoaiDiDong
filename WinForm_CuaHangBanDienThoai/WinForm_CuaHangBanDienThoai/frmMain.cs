using BLL;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_CuaHangBanDienThoai
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
          
            InitializeComponent();
            if (frmLogin.quyen.Equals("Admin"))
            {
                lbUser.Text = frmLogin.tennv;
                lbChucVu.Text = frmLogin.quyen;
            }
            else
            {
                lbUser.Text = frmLogin.tendn;
                lbChucVu.Text = frmLogin.quyen;
                //btnTaiKhoan.Visible = false;
                //btnThongKe.Visible = false;
                //btnNhanVien.Visible = false;
                //btnNhapKho.Visible = false;
                //btnSamPham.Visible = false;
                //btnDanhMuc.Visible = false;
                //btnThuongHieu.Visible = false;

                //btnVoucher.Visible = true;
                //btnThuongHieu.Visible = false;
                //button1.Visible = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            this.Visible = false;        
            Program.staffsForm = new frmStaffs();
            Program.staffsForm.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_PhieuNhap_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.categoriesForm = new frmCategories();
            Program.categoriesForm.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Visible = false;
                Program.loginForm = new frmLogin();
                Program.loginForm.Show();
            }
        }
    }
}
