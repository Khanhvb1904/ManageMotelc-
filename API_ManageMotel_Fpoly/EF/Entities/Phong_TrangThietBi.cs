using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Entities
{
    public class Phong_TrangThietBi
    {
        public int maPhong { get; set; }
        public int maTrangThietBi { get; set; }
        public int soLuong { get; set; }
        public bool trangThai { get; set; }
        public Phong Phong { get; set; } 
        public TrangThietBi TrangThietBi { get; set; }
    }
}
