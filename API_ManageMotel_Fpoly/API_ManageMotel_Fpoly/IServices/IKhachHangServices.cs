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
        #region Lấy thông Tin Khách Hàng
        public Task<List<FullinfoCustomer>> LayDanhSachFullKhachHang();
        public Task<List<KhachHang>> LayDanhSachKhachHang();
        public Task<List<Xe>> LayDanhSachXeKhachHang();
        public Task<List<LoaiXe>> LayDanhSachLoaiKhachHang();
        #endregion

        #region Thêm Thông Tin Khách Hàng 
        public Task<int> ThemThongTinKhachHang(KhachHang khach);
        public Task<int> ThemThongTinXeKhachHang(Xe xe);
        public Task<int> ThemThongTinLoaiXeKhachHang(LoaiXe loaiXe);
        #endregion

        #region Sửa Thông Tin Khách Hàng
        public Task<int> SuaThongTinKhachHang(KhachHang khach);
        public Task<int> SuaThongTinXeKhachHang(Xe xe);
        public Task<int> SuaThongTinLoaiXeKhachHang(LoaiXe loaiXe);
        #endregion

        #region Xóa Thông Tin Khách Hàng
        public Task<int> XoaThongTinKhachHang(KhachHang khach);
        public KhachHang layidkhachhang(int id);

        public Task<int> XoaThongTinXeKhachHang(Xe xe);
        public Xe layidXekhachhang(int id);

        public Task<int> XoaThongTinLoaiXeKhachHang(LoaiXe loaiXe);
        public LoaiXe layidLoaiXekhachhang(int id);
        #endregion


    }
}
