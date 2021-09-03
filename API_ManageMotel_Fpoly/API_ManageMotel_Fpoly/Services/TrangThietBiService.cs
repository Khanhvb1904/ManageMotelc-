using API_ManageMotel_Fpoly.EF.Entities;
using API_ManageMotel_Fpoly.EF.ManageMotelDbContext;
using API_ManageMotel_Fpoly.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.Services
{
    public class TrangThietBiService: ITrangThietBiService
    {
        private readonly ManageMotelDbContext _context;
        public TrangThietBiService(ManageMotelDbContext context)
        {
            _context = context;
        }

        public Task<List<LoaiThietBi>> DanhSachLoaiThietBi()
        {
            return Task.FromResult(_context.LoaiThietBi.ToList());
        }

        public Task<List<TrangThietBi>> DanhSachThietBi()
        {
            return Task.FromResult(_context.TrangThietBi.ToList());
        }

        public async Task<int> SuaLoaiThietBi(int Id, LoaiThietBi model)
        {
            var loaiThietBi = _context.LoaiThietBi.Where(c => c.Id == Id).FirstOrDefault();
            if (loaiThietBi != null)
            {
                loaiThietBi.ten = model.ten;
                _context.LoaiThietBi.Update(loaiThietBi);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<int> SuaThietBi(int Id, TrangThietBi model)
        {
            var thietBi = _context.TrangThietBi.Where(c => c.Id == Id).FirstOrDefault();
            if (thietBi != null)
            {
                thietBi.maLoaiThietBi = model.maLoaiThietBi;
                thietBi.ten = model.ten;
                thietBi.gia = model.gia;
                thietBi.soLuong = model.soLuong;
                thietBi.trangThai = model.trangThai;
                _context.TrangThietBi.Update(thietBi);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<int> TaoLoaiThietBi(LoaiThietBi model)
        {
            if (model != null)
            {
                _context.LoaiThietBi.Add(model);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<int> TaoThietBi(TrangThietBi model)
        {
            if (model != null)
            {
                _context.TrangThietBi.Add(model);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public Task<LoaiThietBi> ThongTinLoaiThietBi(int Id)
        {
            return Task.FromResult(_context.LoaiThietBi.Where(c => c.Id == Id).FirstOrDefault());
        }

        public Task<TrangThietBi> ThongTinThietBi(int Id)
        {
            return Task.FromResult(_context.TrangThietBi.Where(c => c.Id == Id).FirstOrDefault());
        }

        public async Task<int> XoaLoaiThietBi(int Id)
        {
            var loaiThietBi = _context.LoaiThietBi.Where(c => c.Id == Id).FirstOrDefault();
            if (loaiThietBi != null)
            {
                _context.LoaiThietBi.Remove(loaiThietBi);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<int> XoaThietBi(int Id)
        {
            var thietBi = _context.TrangThietBi.Where(c => c.Id == Id).FirstOrDefault();
            if (thietBi != null)
            {
                _context.TrangThietBi.Remove(thietBi);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
    }
}
