using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Entities
{
    public class TrangThietBi
    {
        public int Id { get; set; }
        public int maLoaiThietBi { get; set; }
        public string ten { get; set; }
        public decimal gia { get; set; }
        public int soLuong { get; set; }
        public bool trangThai { get; set; }
        public LoaiThietBi LoaiThietBi { get; set; }
        public List<Phong_TrangThietBi> Phong_TrangThietBi { get; set; }
        public List<ChiTietHopDong_TrangThietBi> ChiTietHopDong_TrangThietBi { get; set; }
    }
}
