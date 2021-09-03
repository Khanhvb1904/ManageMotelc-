using API_ManageMotel_Fpoly.EF.Entities;
using API_ManageMotel_Fpoly.EF.ManageMotelDbContext;
using API_ManageMotel_Fpoly.IServices;
using API_ManageMotel_Fpoly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.Services
{
    public class KhachHangServices : IKhachHangServices
    {
        private readonly ManageMotelDbContext _context;

        public KhachHangServices(ManageMotelDbContext context)
        {
            _context = context;
        }

        public async Task<List<FullinfoCustomer>> LayDanhSachKhachHang()
        {
            var laythongtinkhachhang = (from a in _context.KhachHang
                                        join b in _context.Xe on a.Id equals b.maKhachHang
                                        join c in _context.LoaiXe on b.maLoaiXe equals c.Id
                                        group a by new
                                        {
                                            #region group
                                            a.name,
                                            a.cmnd,
                                            a.ngayCap,
                                            a.noiCap,
                                            a.HKTT,
                                            a.gioiTinh,
                                            a.SDT,
                                            a.email,
                                            a.trangThai,
                                            c.tenloaixe,
                                            b.tenxe,
                                            b.bienSo
                                            #endregion

                                        } into g
                                        select new FullinfoCustomer
                                        {
                                            #region Select
                                            TenKhachHang = g.Key.name,
                                            cmnd = g.Key.cmnd,
                                            ngayCap = g.Key.ngayCap,
                                            noiCap = g.Key.noiCap,
                                            HKTT = g.Key.HKTT,
                                            gioiTinh = g.Key.gioiTinh,
                                            SDT = g.Key.SDT,
                                            email = g.Key.email,
                                            trangThai = g.Key.trangThai,
                                            tenloaixe = g.Key.tenloaixe,
                                            tenxe = g.Key.tenxe,
                                            bienSo = g.Key.bienSo
                                            #endregion
                                        }).ToList();

            return await Task.FromResult(laythongtinkhachhang);
        }

        public FullinfoCustomer laykhachhang(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> SuaThongTinKhachHang(FullinfoCustomer khach)
        {
            throw new NotImplementedException();
        }

        public async Task<int> ThemThongTinKhachHang(KhachHang khach, Xe xe, LoaiXe loaiXe)
        {
            var themthongtinkhachhang = new KhachHang()
            {
                name = khach.name,
                cmnd = khach.cmnd,
                ngayCap = khach.ngayCap,
                noiCap = khach.noiCap,
                HKTT = khach.HKTT,
                gioiTinh = khach.gioiTinh,
                email = khach.email,
                SDT = khach.SDT,
                trangThai = khach.trangThai
            };
            var themthongtinxekhachhang = new Xe()
            {
                tenxe = xe.tenxe,
                bienSo = xe.bienSo
            };
            var themthongtinloaixekhachhang = new LoaiXe()
            {
                tenloaixe = loaiXe.tenloaixe
            };
            if (themthongtinkhachhang != null && themthongtinxekhachhang != null && themthongtinloaixekhachhang != null)
            {
                _context.KhachHang.Add(themthongtinkhachhang);
                _context.Xe.Add(themthongtinxekhachhang);
                _context.LoaiXe.Add(themthongtinloaixekhachhang);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public Task<int> XoaThongTinKhachHang(FullinfoCustomer khach)
        {
            throw new NotImplementedException();
        }
    }
}
