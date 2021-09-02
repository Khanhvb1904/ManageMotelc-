using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Entities
{
    public class NhaTro
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int soTang { get; set; }
        public int soPhong { get; set; }
        public string diaChi { get; set; }
        public DateTime ngayChotSo { get; set; }
        public string SDT { get; set; }
        public string moTa { get; set; }
        public List<Phong> Phong { get; set; }
    }
}
