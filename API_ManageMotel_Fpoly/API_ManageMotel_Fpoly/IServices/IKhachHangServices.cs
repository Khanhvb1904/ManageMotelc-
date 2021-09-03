using API_ManageMotel_Fpoly.EF.Entities;
using API_ManageMotel_Fpoly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.IServices
{
    public interface IKhachHangServices
    {
        public Task<List<FullinfoCustomer>> LayDanhSachKhachHang();
        public Task<int> ThemThongTinKhachHang(KhachHang khach , Xe xe , LoaiXe loaiXe);
        public Task<int> SuaThongTinKhachHang(FullinfoCustomer khach);
        public Task<int> XoaThongTinKhachHang(FullinfoCustomer khach);
        public FullinfoCustomer laykhachhang(int id);
    }
}
