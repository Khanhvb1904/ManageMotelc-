using API_ManageMotel_Fpoly.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.IServices
{
    public interface IDichVuService
    {
        public Task<int> TaoLoaiDichVu(LoaiDichVu model);
        public Task<int> SuaLoaiDichVu(int Id, LoaiDichVu model);
        public Task<int> XoaLoaiDichVu(int Id);
        public Task<List<LoaiDichVu>> DanhSachLoaiDichVu();
        public Task<LoaiDichVu> ThongTinLoaiDichVu(int Id);
        public Task<int> TaoDichVu(DichVu model);
        public Task<int> SuaDichVu(int Id, DichVu model);
        public Task<int> XoaDichVu(int Id);
        public Task<List<DichVu>> DanhSachDichVu();
        public Task<DichVu> ThongTinDichVu(int Id);
    }
}
