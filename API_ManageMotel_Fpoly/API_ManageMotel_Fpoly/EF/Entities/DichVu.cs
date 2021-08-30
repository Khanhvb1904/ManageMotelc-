using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Entities
{
    public class DichVu
    {
        public int Id { get; set; }
        public int maLoaiDichVu { get; set; }
        public string ten { get; set; }
        public decimal gia { get; set; }
        public bool trangThai { get; set; }
        public LoaiDichVu LoaiDichVu { get; set; }
        public List<ChiTietHopDong_DichVu> ChiTietHopDong_DichVu { get; set; }
    }
}
