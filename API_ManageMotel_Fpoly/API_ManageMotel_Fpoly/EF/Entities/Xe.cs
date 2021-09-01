using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Entities
{
    public class Xe
    {
        public int Id { get; set; }
        public int maLoaiXe { get; set; }
        public int maKhachHang { get; set; }
        public string ten { get; set; }
        public string bienSo { get; set; }
        public KhachHang KhachHang { get; set; }
        public LoaiXe LoaiXe { get; set; }
    }
}
