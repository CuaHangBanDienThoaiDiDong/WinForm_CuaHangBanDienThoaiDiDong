using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriesBLL
    {
        CUAHANGDIENTHOAIDataContext context;
        public CategoriesBLL()
        {
            context= new CUAHANGDIENTHOAIDataContext();
        }
        public List<CategoriesDTO> getDanhSachDanhMuc()
        {
            var lst = context.tb_ProductCategories
                           .Select(nv => new CategoriesDTO
                           {
                               MaDanhMuc = nv.ProductCategoryId,
                               TenDanhMuc = nv.Title,
                               ImageDanhMuc = nv.Icon,
                               
                           })
                           .ToList();

            return lst;
        }
        public List<CategoriesDTO> GetDanhMucList_MaDanhMuc(string texttimkiem)
        {
            try
            {
                var danhmucList = (from p in context.tb_ProductCategories
                                   where p.ProductCategoryId == int.Parse(texttimkiem)
                                   select new CategoriesDTO
                                   {
                                       MaDanhMuc = p.ProductCategoryId,
                                       TenDanhMuc = p.Title,
                                       ImageDanhMuc = p.Icon


                                   }).ToList();

                return danhmucList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public List<CategoriesDTO> GetDanhMucList_TenDanhMuc(string texttimkiem)
        {
            try
            {
                var danhmucList = (from p in context.tb_ProductCategories
                                   where p.Title == texttimkiem
                                   select new CategoriesDTO
                                   {
                                       MaDanhMuc = p.ProductCategoryId,
                                       TenDanhMuc = p.Title,
                                       ImageDanhMuc = p.Icon


                                   }).ToList();

                return danhmucList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }
    }
}
