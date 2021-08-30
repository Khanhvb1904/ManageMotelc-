using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Entities
{
    public class LoaiPhong
    {
        public int Id { get; set; }
        public string tenGoi { get; set; }
        public int sucChua { get; set; } 
        public bool trangThai { get; set; }
        public List<Phong> Phong { get; set; }
    }
}
