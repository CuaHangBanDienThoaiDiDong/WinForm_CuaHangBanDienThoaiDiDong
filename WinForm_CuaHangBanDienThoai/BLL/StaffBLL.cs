using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StaffBLL
    {
        CUAHANGDIENTHOAIDataContext context;
        public StaffBLL() 
        {
            context= new CUAHANGDIENTHOAIDataContext();
        }
        public List<StaffDTO> getDanhSachNhanVien()
        {
            var lst = context.tb_Staffs
                           .Select(nv => new StaffDTO
                           {

                               MaNhanVien = nv.Code,
                               TenNV = nv.NameStaff,
                               NgaySinh = (DateTime)nv.Birthday,
                               GioiTinh = nv.Sex,
                               Email = nv.Email,
                              
                               SDT = nv.PhoneNumber,
                              
                               DiaChi = nv.Location,
                           })
                           .ToList();

            return lst;
        }
        public List<StaffDTO> TimKiemNhanVienTheoTen(string str)
        {
            var lst = context.tb_Staffs
                           .Select(nv => new StaffDTO
                           {
                               MaNhanVien = nv.Code,
                               TenNV = nv.NameStaff,
                               NgaySinh = (DateTime)nv.Birthday,
                               GioiTinh = nv.Sex,
                               Email = nv.Email,
                               SDT = nv.PhoneNumber,
                               DiaChi = nv.Location,
                           })
                           .Where(nv => nv.TenNV.Contains(str))
                           .ToList();

            return lst;
        }
        public List<StaffDTO> TimKiemNhanVienTheoSDT(string str)
        {
            var lst = context.tb_Staffs
                           .Select(nv => new StaffDTO
                           {
                               MaNhanVien = nv.Code,
                               TenNV = nv.NameStaff,
                               NgaySinh = (DateTime)nv.Birthday,
                               GioiTinh = nv.Sex,
                               Email = nv.Email,
                               SDT = nv.PhoneNumber,
                               DiaChi = nv.Location,
                           })
                           .Where(nv => nv.SDT.Contains(str))
                           .ToList();

            return lst;
        }

        public List<StaffDTO> TimKiemNhanVienTheoDiaChi(string str)
        {
            var lst = context.tb_Staffs
                           .Select(nv => new StaffDTO
                           {
                               MaNhanVien = nv.Code,
                               TenNV = nv.NameStaff,
                               NgaySinh = (DateTime)nv.Birthday,
                               GioiTinh = nv.Sex,
                               Email = nv.Email,
                               SDT = nv.PhoneNumber,
                               DiaChi = nv.Location,
                           })
                           .Where(nv => nv.DiaChi.Contains(str))
                           .ToList();

            return lst;
        }
        public int LayIDtuEmail(string email)
        {
            // Kiểm tra xem số điện thoại có tồn tại không
            var nhanVien = context.tb_Staffs.FirstOrDefault(kh => kh.Email == email);

            // Nếu khách hàng tồn tại, trả về MaKhachHang, ngược lại trả về giá trị mặc định
            return nhanVien != null ? nhanVien.StaffId : -1;
        }



        public bool KiemTraEmail(string email)
        {
            var nhanVien = context.tb_Staffs.SingleOrDefault(kh => kh.Email == email);
            // Nếu tồn tại khách hàng với email này, trả về true, ngược lại trả về false
            return nhanVien != null;
        }

        public void CapNhatNhanVien(string hoTen, string email, DateTime date, string soDienThoai, string cccd, string diaChi, int id_nhanvien)
        {
            var nhanvienToUpdate = context.tb_Staffs.SingleOrDefault(kh => kh.StaffId == id_nhanvien);
            if (nhanvienToUpdate != null)
            {
                nhanvienToUpdate.NameStaff = hoTen;
                nhanvienToUpdate.Email = email;
                nhanvienToUpdate.Birthday = date;
                nhanvienToUpdate.PhoneNumber = soDienThoai;
                nhanvienToUpdate.PhoneNumber = cccd;
                nhanvienToUpdate.Location = diaChi;

                context.SubmitChanges();
            }
        }

        public void ThemNhanVien(string hoTen, string email, string soDienThoai, string diaChi, DateTime date, string gt)
        {
            context.Them_Nhan_Vien(
                hoTen,
                email,
                soDienThoai,
                diaChi,
                date,
                gt
            );
            context.SubmitChanges();

        }


        //public void XoaNhanVien(int MaNhanVien)
        //{
        //    var nhanvienToRemove = context.NhanViens.SingleOrDefault(dv => dv.MaNhanVien == MaNhanVien);
        //    if (nhanvienToRemove != null)
        //    {
        //        context.NhanViens.DeleteOnSubmit(nhanvienToRemove);
        //        context.SubmitChanges();
        //    }
        //}

    }
}
