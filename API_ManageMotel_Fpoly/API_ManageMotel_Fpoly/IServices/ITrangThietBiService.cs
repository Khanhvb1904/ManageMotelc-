using API_ManageMotel_Fpoly.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.IServices
{
    public interface ITrangThietBiService
    {
        public Task<int> TaoLoaiThietBi(LoaiThietBi model);
        public Task<int> SuaLoaiThietBi(int Id,LoaiThietBi model);
        public Task<int> XoaLoaiThietBi(int Id);
        public Task<int> TaoThietBi(TrangThietBi model);
        public Task<int> SuaThietBi(int Id,TrangThietBi model);
        public Task<int> XoaThietBi(int Id);
        public Task<List<TrangThietBi>> DanhSachThietBi();
        public Task<TrangThietBi> ThongTinThietBi(int Id);
        public Task<List<LoaiThietBi>> DanhSachLoaiThietBi();
        public Task<LoaiThietBi> ThongTinLoaiThietBi(int Id);
    }
}
