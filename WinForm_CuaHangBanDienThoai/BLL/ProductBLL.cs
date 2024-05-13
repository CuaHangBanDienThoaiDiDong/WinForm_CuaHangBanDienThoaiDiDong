using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using static System.Net.Mime.MediaTypeNames;

namespace BLL
{
    public class ProductsBLL
    {
        CUAHANGDIENTHOAIDataContext context;
        public ProductsBLL()
        {
            context = new CUAHANGDIENTHOAIDataContext();
        }
        // lấy ra danh sách sản phẩm 
        public List<ProductDTO> getDanhSachSanPham()
        {
            var query = from sp in context.tb_Products
                        join dm in context.tb_ProductCategories on sp.ProductCategoryId equals dm.ProductCategoryId
                        join th in context.tb_ProductCompanies on sp.ProductCompanyId equals th.ProductCompanyId
                        select new ProductDTO
                        {

                            TenSanPham = sp.Title,
                            CongNghePin = sp.CongNghePin,
                            Sim = sp.Sim,
                            CongKetNoi = sp.CongKetNoi,
                            HeDieuHanh = sp.HeDieuHanh,
                            TenDanhMuc = sp.tb_ProductCategory.Title,
                            TenThuongHieu = sp.tb_ProductCompany.Title,
                        };
            return query.ToList();
        }
        // sắp xếp giảm dần 
        public List<ProductDTO> getDanhSachSanPhamDescending()
        {
            var query = from sp in context.tb_Products
                        join dm in context.tb_ProductCategories on sp.ProductCategoryId equals dm.ProductCategoryId
                        join th in context.tb_ProductCompanies on sp.ProductCompanyId equals th.ProductCompanyId
                        orderby sp.ProductsId descending
                        select new ProductDTO
                        {

                            TenSanPham = sp.Title,
                            CongNghePin = sp.CongNghePin,
                            Sim = sp.Sim,
                            CongKetNoi = sp.CongKetNoi,
                            HeDieuHanh = sp.HeDieuHanh,
                            TenDanhMuc = sp.tb_ProductCategory.Title,
                            TenThuongHieu = sp.tb_ProductCompany.Title,
                        };
            return query.ToList();


        }
        public List<ProductDTO> getDanhSachSanPham(string tensp)
        {
            var query = from sp in context.tb_Products
                        join dm in context.tb_ProductCategories on sp.ProductCategoryId equals dm.ProductCategoryId
                        join th in context.tb_ProductCompanies on sp.ProductCompanyId equals th.ProductCompanyId
                        where sp.Title.Contains(tensp)
                        select new ProductDTO
                        {

                            TenSanPham = sp.Title,
                            CongNghePin = sp.CongNghePin,
                            Sim = sp.Sim,
                            CongKetNoi = sp.CongKetNoi,
                            HeDieuHanh = sp.HeDieuHanh,
                            TenDanhMuc = sp.tb_ProductCategory.Title,
                            TenThuongHieu = sp.tb_ProductCompany.Title,
                        };
            return query.ToList();

        }


    }
}
