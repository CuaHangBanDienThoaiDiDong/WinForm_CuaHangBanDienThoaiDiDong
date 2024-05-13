using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_CuaHangBanDienThoai
{
    public partial class frmStaffs : Form
    {
        StaffBLL staffBLL;
        List<StaffDTO> nhanvienList;
        
        public frmStaffs()
        {
            InitializeComponent();
            staffBLL = new StaffBLL();
            LoadDataNhanVien();

            
           
        }

        public void LoadDataNhanVien()
        {
            nhanvienList = staffBLL.getDanhSachNhanVien();
            tbl_NhanVien.DataSource = nhanvienList;

            tbl_NhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            tbl_NhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            tbl_NhanVien.Columns[2].HeaderText = "Ngày Sinh";
            tbl_NhanVien.Columns[3].HeaderText = "Giới Tính";
            tbl_NhanVien.Columns[4].HeaderText = "Email";
            tbl_NhanVien.Columns[5].HeaderText = "SĐT";
            tbl_NhanVien.Columns[6].HeaderText = "Địa Chỉ";


            cbo_Gioitinh.Items.AddRange(new string[] { "Nam", "Nữ", "Khác" });
        }
        private void tbl_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = tbl_NhanVien.SelectedRows[0];
            txtMaNV.Text = selectedRow.Cells[0].Value.ToString();
            txtTenNV.Text = selectedRow.Cells[1].Value.ToString();
            dateNgaySinh.Value = DateTime.Parse(selectedRow.Cells[2].Value.ToString());
            string gioiTinh = selectedRow.Cells[3].Value.ToString();
            if (cbo_Gioitinh.Items.Contains(gioiTinh))
            {
                cbo_Gioitinh.SelectedItem = gioiTinh;
            }
            else
            {
                // Nếu giới tính không tồn tại trong ComboBox, thêm nó vào
                cbo_Gioitinh.Items.Add(gioiTinh);
                cbo_Gioitinh.SelectedItem = gioiTinh;
            }

            txtEmail.Text = selectedRow.Cells[4].Value.ToString();
            txtSDT.Text = selectedRow.Cells[5].Value.ToString();
            txtDiaChi.Text = selectedRow.Cells[6].Value.ToString();




            ll.Enabled = false;
            ss.Enabled = true;
            xx.Enabled = true;
            txtTenNV.Enabled = true;
            txtEmail.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            cbo_Gioitinh.Enabled = true;
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

        private void tbl_NhanVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = tbl_NhanVien.SelectedRows[0];
            txtMaNV.Text = selectedRow.Cells[0].Value.ToString();
            txtTenNV.Text = selectedRow.Cells[1].Value.ToString();
            dateNgaySinh.Value = DateTime.Parse(selectedRow.Cells[2].Value.ToString());
            cbo_Gioitinh.Text = selectedRow.Cells[3].Value.ToString();
            txtEmail.Text = selectedRow.Cells[4].Value.ToString();
            txtSDT.Text = selectedRow.Cells[5].Value.ToString();
            txtDiaChi.Text = selectedRow.Cells[6].Value.ToString();

            ll.Enabled = false;
            ss.Enabled = true;
            xx.Enabled = true;
            txtTenNV.Enabled = true;
            txtEmail.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            cbo_Gioitinh.Enabled = true;
        }
        public bool KiemTraNhapEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        static bool KiemTraNhapNgaySinh(string str)
        {
            if (DateTime.TryParseExact(str, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime ngaysinh))
            {
                int tuoi = TinhSoTuoi(ngaysinh);
                return tuoi > 18;
            }
            return false;
        }

        static int TinhSoTuoi(DateTime ngaysinh)
        {
            DateTime hientai = DateTime.Now;
            int tuoi = hientai.Year - ngaysinh.Year;
            if (ngaysinh > hientai.AddYears(-tuoi))
            {
                tuoi--;
            }
            return tuoi;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (staffBLL.KiemTraEmail(txtEmail.Text))
                MessageBox.Show("Email đã tồn tại. Vui lòng nhập một email khác.");
            else
            {
                if (txtSDT.Text.Length != 10)
                {
                    MessageBox.Show("SĐT chưa hợp lệ");
                    txtSDT.Focus();
                    return;
                }
                else
                {
                    if (cbo_Gioitinh.SelectedIndex==-1)
                    {
                        MessageBox.Show("Giới tính chưa hợp lệ");
                        cbo_Gioitinh.Focus();
                        return;
                    }
                    else
                    {
                        if (!KiemTraNhapEmail(txtEmail.Text))
                        {
                            MessageBox.Show("Email chưa hợp lệ");
                            txtEmail.Focus();
                            return;
                        }
                        else
                        {
                            if (!KiemTraNhapNgaySinh(dateNgaySinh.Text))
                            {
                                MessageBox.Show("Tuổi phải trên 18");
                                return;
                            }
                            else
                            {
                                if (result == DialogResult.Yes)
                                {
                                    staffBLL.ThemNhanVien(txtTenNV.Text.Trim(), txtEmail.Text.Trim(), txtSDT.Text.Trim(), txtDiaChi.Text.Trim(), dateNgaySinh.Value, cbo_Gioitinh.Text.Trim());
                                    LoadDataNhanVien();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnTimKiem_TextChanged(object sender, EventArgs e)
        {
            switch (cboTim.SelectedIndex)
            {
                case 0:
                    tbl_NhanVien.DataSource = staffBLL.TimKiemNhanVienTheoTen(btnTimKiem.Text.Trim());
                    break;
                case 1:
                    tbl_NhanVien.DataSource = staffBLL.TimKiemNhanVienTheoSDT(btnTimKiem.Text.Trim());
                    break;
                case 2:
                    tbl_NhanVien.DataSource = staffBLL.TimKiemNhanVienTheoDiaChi(btnTimKiem.Text.Trim());
                    break;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dateNgaySinh.Value = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));
            txtMaNV.Text = string.Empty;
            txtTenNV.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            cbo_Gioitinh.Text = string.Empty;
            txtTenNV.Enabled = true;
            txtEmail.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            cbo_Gioitinh.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtTenNV.Focus();
        }








        //private void btnThoat_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    Program.mainForm.Show();
        //}


    }
}
