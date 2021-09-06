using API_ManageMotel_Fpoly.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.IServices
{
    public interface IHopDongServices
    {
        public Task<List<HopDong>> LayDanhSachHopDong();
        public Task<int> SuaThongTinHopDong(HopDong hopDong);
        public Task<int> ThemHopDong(HopDong hopDong);
        public Task<int> XoaHopDong(HopDong hopDong);
        public HopDong layidhopdong(int id);
    }
}
