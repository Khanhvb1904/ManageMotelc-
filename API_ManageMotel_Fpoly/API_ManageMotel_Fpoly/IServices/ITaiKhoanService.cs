using API_ManageMotel_Fpoly.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.IServices
{
    public interface ITaiKhoanService
    {
        public Task<int> TaoTaiKhoan(TaiKhoan model);
        public Task<int> SuaTaiKhoan(int Id, TaiKhoan model);
        public Task<int> XoaTaiKhoan(int Id);
        public Task<List<TaiKhoan>> DanhSachTaiKhaon();
        public Task<TaiKhoan> ThongTinTaiKhoan(int Id);
    }
}
