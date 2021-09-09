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
        #region Lấy Danh Sách và Thông Tin Khách Hàng
        public async Task<List<FullinfoCustomer>> LayDanhSachFullKhachHang()    
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

        public Task<List<KhachHang>> LayDanhSachKhachHang()
        {
            List<KhachHang> _Lstkhachhang = new List<KhachHang>();
            var lstkhach = _context.KhachHang.ToList();
            if (lstkhach.Count>=0)
            {
                foreach (var item in lstkhach)
                {
                    _Lstkhachhang.Add(item);
                }
            }
            return Task.FromResult(_Lstkhachhang);
        }

        public Task<List<Xe>> LayDanhSachXeKhachHang()
        {
            List<Xe> _Lstxe = new List<Xe>();
            var lstxe = _context.Xe.ToList();
            if (lstxe.Count >= 0)
            {
                foreach (var item in lstxe)
                {
                    _Lstxe.Add(item);
                }
            }
            return Task.FromResult(_Lstxe);
        }

        public Task<List<LoaiXe>> LayDanhSachLoaiKhachHang()
        {
            List<LoaiXe> _Lstloaixe = new List<LoaiXe>();
            var lstloaixe = _context.LoaiXe.ToList();
            if (lstloaixe.Count >= 0)
            {
                foreach (var item in lstloaixe)
                {
                    _Lstloaixe.Add(item);
                }
            }
            return Task.FromResult(_Lstloaixe);
        }
        #endregion

        #region Thêm Thông Tin Khách Hàng
        public async Task<int> ThemThongTinKhachHang(KhachHang khach)
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
            if (themthongtinkhachhang != null)
            {
                _context.KhachHang.Add(themthongtinkhachhang);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<int> ThemThongTinLoaiXeKhachHang(LoaiXe loaiXe)
        {
            var themthongtinLoaiXekhachhang = new LoaiXe()
            {
                tenloaixe = loaiXe.tenloaixe
            };
            if (themthongtinLoaiXekhachhang != null)
            {
                _context.LoaiXe.Add(themthongtinLoaiXekhachhang);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<int> ThemThongTinXeKhachHang(Xe xe)
        {
            var themthongtinXekhachhang = new Xe()
            {
                tenxe = xe.tenxe,
                bienSo = xe.bienSo,
                maLoaiXe = xe.maLoaiXe,
                maKhachHang = xe.maKhachHang
            };
            if (themthongtinXekhachhang != null)
            {
                _context.Xe.Add(themthongtinXekhachhang);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
        #endregion

        #region Sửa Thông Tin Khách Hàng
        public async Task<int> SuaThongTinKhachHang(KhachHang khach)
        {
            var SuaThongTinKhach = _context.KhachHang.Where(c => c.Id == khach.Id).FirstOrDefault();
            if (SuaThongTinKhach != null)
            {
                SuaThongTinKhach.name = khach.name;
                SuaThongTinKhach.cmnd = khach.cmnd;
                SuaThongTinKhach.ngayCap = khach.ngayCap;
                SuaThongTinKhach.noiCap = khach.noiCap;
                SuaThongTinKhach.HKTT = khach.HKTT;
                SuaThongTinKhach.gioiTinh = khach.gioiTinh;
                SuaThongTinKhach.SDT = khach.SDT;
                SuaThongTinKhach.email = khach.email;
                SuaThongTinKhach.trangThai = khach.trangThai;
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<int> SuaThongTinLoaiXeKhachHang(LoaiXe loaiXe)
        {
            var SuathongtinloaixeKhach = _context.LoaiXe.Where(c => c.Id == loaiXe.Id).FirstOrDefault();
            if (SuathongtinloaixeKhach != null)
            {
                SuathongtinloaixeKhach.tenloaixe = loaiXe.tenloaixe;
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<int> SuaThongTinXeKhachHang(Xe xe)
        {
            var suathongtinxekhac = _context.Xe.Where(c => c.Id == xe.Id).FirstOrDefault();
            if (suathongtinxekhac!= null)
            {
                suathongtinxekhac.tenxe = xe.tenxe;
                suathongtinxekhac.bienSo = xe.bienSo;
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }


        #endregion

        #region Xóa Thông Tin Khách Hàng

        public KhachHang layidkhachhang(int id)
        {
            var khachhang = _context.KhachHang.Where(c => c.Id == id).FirstOrDefault();
            return khachhang;
        }

        public async Task<int> XoaThongTinKhachHang(KhachHang khach)
        {
            if (khach != null)
            {
                _context.KhachHang.Remove(khach);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public Xe layidXekhachhang(int id)
        {
            var xe = _context.Xe.Where(c => c.Id == id).FirstOrDefault();
            return xe;
        }

        public async Task<int> XoaThongTinXeKhachHang(Xe xe)
        {
            if (xe != null)
            {
                 _context.Xe.Remove(xe);
                await _context.SaveChangesAsync();
                return 0;
            }
            return 1;
        }

        public LoaiXe layidLoaiXekhachhang(int id)
        {
            var loaixe = _context.LoaiXe.Where(c => c.Id == id).FirstOrDefault();
            return loaixe;
        }

        public async Task<int> XoaThongTinLoaiXeKhachHang(LoaiXe loaiXe)
        {
            if (loaiXe != null)
            {
                _context.LoaiXe.Remove(loaiXe);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        #endregion

    }
}
