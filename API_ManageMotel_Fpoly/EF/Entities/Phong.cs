using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Entities
{
    public class Phong
    {
        public int Id { get; set; }
        public int maNhaTro { get; set; }
        public int maLoaiPhong { get; set; }
        public int soPhong { get; set; }
        public decimal giaPhong { get; set; }
        public string moTa { get; set; }
        public bool trangThai { get; set; }
        public LoaiPhong LoaiPhong { get; set; }
        public List<Phong_TrangThietBi> Phong_TrangThietBi { get; set; }
        public List<ChiTietHopDong_DichVu> ChiTietHopDong_DichVu { get; set; }
        public List<ChiTietHopDong_TrangThietBi> ChiTietHopDong_TrangThietBi { get; set; }
    }
}
