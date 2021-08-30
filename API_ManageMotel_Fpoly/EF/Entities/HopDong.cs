using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Entities
{
    public class HopDong
    {
        public int Id { get; set; }
        public int maKhachHang { get; set; }
        public DateTime ngayTao { get; set; }
        public DateTime ngayKiKet { get; set; } 
        public DateTime ngayHetHan { get; set; }
        public List<ChiTietHopDong_TrangThietBi> ChiTietHopDong_TrangThietBi { get; set; }
        public List<ChiTietHopDong_DichVu> ChiTietHopDong_DichVu { get; set; }
    }
}
