using API_ManageMotel_Fpoly.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.IServices
{
    public interface IThongTinNhaTroServices
    {
        public Task<List<NhaTro>> LayDanhSachNhatro();
        public Task<int> ThemThongTinnhatro(NhaTro nhaTro);
        public Task<int> SuaThongTinnhatro(NhaTro nhaTro);
        public Task<int> Xoanhatro(NhaTro nhaTro);
        public Task<int> chitietnhatro(NhaTro nhaTro);
        public NhaTro laynhatro(int id);
    }
}
