using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Entities
{
    public class LoaiXe
    {
        public int Id { get; set; }
        public string tenloaixe { get; set; }
        public List<Xe> Xe { get; set; }
    }
}
