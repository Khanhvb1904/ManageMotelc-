using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.Models
{
    public class FullinfoCustomer
    {
        public int Id { get; set; }

        public string TenKhachHang { get; set; }
        public string cmnd { get; set; }
        public string ngayCap { get; set; }
        public string noiCap { get; set; }
        public string HKTT { get; set; }
        public bool gioiTinh { get; set; }
        public string SDT { get; set; }
        public string email { get; set; }
        public bool trangThai { get; set; }
        public string tenloaixe { get; set; }
        public string tenxe { get; set; }
        public string bienSo { get; set; }
    }
}
