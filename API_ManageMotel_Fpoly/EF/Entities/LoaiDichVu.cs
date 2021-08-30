using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Entities
{
    public class LoaiDichVu
    {
        public int Id { get; set; }
        public string ten { get; set; }
        public bool trangThai { get; set; } 
        public List<DichVu> DichVu { get; set; }
    }
}
