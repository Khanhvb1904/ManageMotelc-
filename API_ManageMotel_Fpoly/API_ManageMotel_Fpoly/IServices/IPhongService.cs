using API_ManageMotel_Fpoly.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.IServices
{
    public interface IPhongService
    {
        public Task<int> TaoPhong(Phong model);
        public Task<int> SuaPhong(int Id, Phong model);
        public Task<int> XoaPhong(int Id);
        public Task<Phong> LayThongTinPhong(int Id);
        public Task<List<Phong>> DanhSachPhong();
    }
}
