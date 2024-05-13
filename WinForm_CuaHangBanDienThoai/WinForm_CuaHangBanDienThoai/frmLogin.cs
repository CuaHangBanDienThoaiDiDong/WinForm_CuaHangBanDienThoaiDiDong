using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_CuaHangBanDienThoai
{
    public partial class frmLogin : Form
    {

        LoginBLL loginBLL;
        public static string quyen = "", tendn = "",tennv="";
        public static int manhanvien = 0;
        CUAHANGDIENTHOAIDataContext context = new CUAHANGDIENTHOAIDataContext();
        TripleDES_Class baomat;


        public frmLogin()
        {
            InitializeComponent();
            loginBLL = new LoginBLL();
            baomat = new TripleDES_Class();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txtMatKhau.PasswordChar = '\0';
            else
                txtMatKhau.PasswordChar = '*';
        }
   


        public void btn_DangNhap_Click(object sender, EventArgs e)
        {
            Login();
        }
        public void Login()
        {
            //string username = loginBLL.LayTenDangNhap(txtTenDangNhap.Text.Trim());
            //string password = baomat.DecryptPassword(loginBLL.LayMatKhau(txtMatKhau.Text.Trim()));
            //tb_Staff n = context.tb_Staffs.SingleOrDefault(u => u.Code == username && u.Password == password);
            string username = (txtTenDangNhap.Text.Trim());
            string password = baomat.DecryptPassword(txtMatKhau.Text.Trim());
            tb_Staff n = context.tb_Staffs.SingleOrDefault(u => u.Code == username && u.Password == password);
            if (txtTenDangNhap.Text.Equals(string.Empty))
            {
                MessageBox.Show("Chưa nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtMatKhau.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (n != null)
                    {
                        if (loginBLL.LayHoatDong(txtTenDangNhap.Text.Trim()) != 0)
                        {

                            tennv = loginBLL.LayTenNhanVien(txtTenDangNhap.Text.Trim());
                            tendn = txtTenDangNhap.Text;
                            quyen = loginBLL.LayQuyen(txtTenDangNhap.Text.Trim());
                            txtTenDangNhap.Text = tennv; txtMatKhau.Text = "";
                            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Program.mainForm = new frmMain();
                            Program.mainForm.Show();
                            this.Visible = false;
                        }
                        else
                            MessageBox.Show("Tài khoản đã bị khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }



            //if (txtTenDangNhap.ToString().Equals(string.Empty))
            //    MessageBox.Show("Chưa nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //else
            //{
            //    if (txtMatKhau.Text.Equals(string.Empty))
            //        MessageBox.Show("Chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    else
            //    {
            //        if (!(username.Equals(txtTenDangNhap.ToString().Trim()) && baomat.Equals(txtMatKhau.Text.Trim())))
            //        {
            //            MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        else
            //        {
            //            tendn = txtTenDangNhap.ToString();
            //            txtTenDangNhap.Text = "";
            //            txtMatKhau.Text = "";
            //            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            Program.mainForm = new frmMain();
            //            Program.mainForm.Show();
            //            this.Visible = false;

            //            //    if (loginBLL.LayHoatDong(txtTenDangNhap.Text.Trim()) != 0)
            //            //    {
            //            //        //tendangnhap = txtUsername.Text.Trim();
            //            //        //tentaikhoan = tk.GetTenTaiKhoan(txtUsername.Text.Trim());
            //            //        manhanvien = lbll.LayMaNhanVien(txtTenDangNhap.Text);
            //            //        tendn = txtTenDangNhap.Text;
            //            //        quyen = lbll.LayQuyen(txtTenDangNhap.Text.Trim());
            //            //        txtTenDangNhap.Text = ""; txtMatKhau.Text = "";
            //            //        MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            //        Program.mainForm = new frmMain();
            //            //        Program.mainForm.Show();
            //            //        this.Visible = false;
            //            //    }
            //            //    else
            //            //        MessageBox.Show("Tài khoản đã bị khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            //}


            //        }
            //    }
            //}
        }
    }
}
        
     
    

