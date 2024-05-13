using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StaffDTO
    {
        private string StaffId { get; set; }
        private string MaNhanVien { get; set; }
        private string TenNV { get; set; }
        private string Pass { get; set; }
        private string SDT { get; set; }
        public DateTime NgaySinh { get; set; }
        private string Email { get; set; }
        private string CCCD { get; set; }

    }
}
