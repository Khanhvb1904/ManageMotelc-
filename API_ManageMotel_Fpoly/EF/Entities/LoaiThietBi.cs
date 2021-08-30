using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Entities
{
    public class LoaiThietBi
    {
        public int Id { get; set; }
        public string ten { get; set; }
        public List<TrangThietBi> TrangThietBi { get; set; } 

    }
}
