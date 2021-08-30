using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Entities
{
    public class TaiKhoan
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; } 
        public string displayName { get; set; }
        public bool trangThai { get; set; }
    }
}
