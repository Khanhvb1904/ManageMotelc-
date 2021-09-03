using API_ManageMotel_Fpoly.EF.Entities;
using API_ManageMotel_Fpoly.EF.ManageMotelDbContext;
using API_ManageMotel_Fpoly.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.Services
{
    public class DichVuService : IDichVuService
    {
        private readonly ManageMotelDbContext _context;
        public DichVuService(ManageMotelDbContext context)
        {
            _context = context;
        }
        public Task<List<DichVu>> DanhSachDichVu()
        {
            return Task.FromResult(_context.DichVu.ToList());
        }

        public Task<List<LoaiDichVu>> DanhSachLoaiDichVu()
        {
            return Task.FromResult(_context.LoaiDichVu.ToList());
        }

        public async Task<int> SuaDichVu(int Id, DichVu model)
        {
            var dichVu = _context.DichVu.Where(c => c.Id == Id).FirstOrDefault();
            if (dichVu != null)
            {
                dichVu.maLoaiDichVu = model.maLoaiDichVu;
                dichVu.ten = model.ten;
                dichVu.gia = model.gia;
                dichVu.trangThai = model.trangThai;
                _context.DichVu.Update(dichVu);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<int> SuaLoaiDichVu(int Id, LoaiDichVu model)
        {
            var loaiDichVu = _context.LoaiDichVu.Where(c => c.Id == Id).FirstOrDefault();
            if (loaiDichVu != null)
            {
                loaiDichVu.ten = model.ten;
                loaiDichVu.trangThai = model.trangThai;
                _context.LoaiDichVu.Update(loaiDichVu);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<int> TaoDichVu(DichVu model)
        {
            if (model != null)
            {
                _context.DichVu.Add(model);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<int> TaoLoaiDichVu(LoaiDichVu model)
        {
            if (model != null)
            {
                _context.LoaiDichVu.Add(model);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public Task<DichVu> ThongTinDichVu(int Id)
        {
            return Task.FromResult(_context.DichVu.Find(Id));
        }

        public Task<LoaiDichVu> ThongTinLoaiDichVu(int Id)
        {
            return Task.FromResult(_context.LoaiDichVu.Find(Id));
        }

        public async Task<int> XoaDichVu(int Id)
        {
            var dichVu = _context.DichVu.Find(Id);
            if (dichVu != null)
            {
                _context.DichVu.Remove(dichVu);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;

        }

        public async Task<int> XoaLoaiDichVu(int Id)
        {
            var loaiDichVu = _context.LoaiDichVu.Find(Id);
            if (loaiDichVu != null)
            {
                _context.LoaiDichVu.Remove(loaiDichVu);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
    }
}
