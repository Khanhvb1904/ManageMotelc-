using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Entities
{
    public class ChiTietHopDong_TrangThietBi
    {
        public int maHopDong { get; set; }
        public int maPhong { get; set; } 
        public int maTrangThietBi { get; set; }
        public int soLuong { get; set; }
        public decimal donGia { get; set; }
        public HopDong HopDong { get; set; }
        public Phong Phong { get; set; }
        public TrangThietBi TrangThietBi { get; set; }
    }
}
