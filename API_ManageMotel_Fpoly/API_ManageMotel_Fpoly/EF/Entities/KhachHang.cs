using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Entities
{
    public class KhachHang
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string cmnd { get; set; }
        public string ngayCap { get; set; }
        public string noiCap { get; set; }
        public string HKTT { get; set; }
        public bool gioiTinh { get; set; }
        public string SDT { get; set; }
        public string email { get; set; }
        public bool trangThai { get; set; }
        public List<HopDong> HopDong { get; set; }
        public List<Xe> Xe { get; set; }
    }
}
