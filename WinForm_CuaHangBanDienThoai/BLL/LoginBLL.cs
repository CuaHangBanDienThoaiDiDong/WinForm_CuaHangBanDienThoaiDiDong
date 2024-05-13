using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBLL
    {
        CUAHANGDIENTHOAIDataContext context;
        public LoginBLL()
        {
            context= new CUAHANGDIENTHOAIDataContext();
        }
        public string LayTenDangNhap(string tendangnhap)
        {
            var account = context.tb_Staffs.FirstOrDefault(nv => nv.Code == tendangnhap);
            if (account != null)
                return account.Code;
            else
                return "Không tìm thấy tài khoản";
        }
        public string LayMatKhau(string tendangnhap)
        {
            var account = context.tb_Staffs.FirstOrDefault(nv => nv.Code == tendangnhap);
            if (account != null)
                return account.Password;
            else
                return "Không tìm thấy tài khoản";
        }
        public string LayQuyen(string taikhoan)
        {
          
            var query = from staff in context.tb_Staffs
                        join role in context.tb_Roles on staff.StaffId equals role.StaffId
                        where staff.Code == taikhoan
                        select role.Note; // Quyền của nhân viên

            string quyen = query.FirstOrDefault();

            return quyen;
        }
        public int LayHoatDong(string tendangnhap)
        {
            var account = context.tb_Staffs.FirstOrDefault(nv => nv.Code == tendangnhap);
            if (account != null)
                return int.Parse(account.FunctionId.ToString());
            else
                return 0;
        }
        public int LayMaNhanVien(string taiKhoan)
        {
            var query = from tk in context.tb_Staffs
                        join nv in context.tb_Roles on tk.StaffId equals nv.StaffId
                        where tk.Code == taiKhoan
                        select nv.StaffId;

            int manv = query.FirstOrDefault();

            return manv;
        }
        public string LayTenNhanVien(string taiKhoan)
        {
            var account = context.tb_Staffs.FirstOrDefault(nv => nv.Code == taiKhoan);
            if (account != null)
                return account.NameStaff;
            else
                return "Không tìm thấy tài khoản";
           
        }
        public string LayGioiTinh(string taiKhoan)
        {
            var query = from gender in context.tb_Staffs
                        select gender.Sex;
            string gt=query.FirstOrDefault();
            return gt;


        }

    }
}
