using API_ManageMotel_Fpoly.EF.Entities;
using API_ManageMotel_Fpoly.EF.ManageMotelDbContext;
using API_ManageMotel_Fpoly.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.Services
{
    public class TaiKhoanService : ITaiKhoanService
    {
        private readonly ManageMotelDbContext _context;
        public TaiKhoanService(ManageMotelDbContext context)
        {
            _context = context;
        }
        public Task<List<TaiKhoan>> DanhSachTaiKhaon()
        {
            return Task.FromResult(_context.TaiKhoan.ToList());
        }

        public async Task<int> SuaTaiKhoan(int Id, TaiKhoan model)
        {
            var taikhoan = _context.TaiKhoan.Where(c => c.Id == Id).FirstOrDefault();
            if (taikhoan != null && model!=null)
            {
                taikhoan.displayName = model.displayName;
                taikhoan.passWord = model.passWord;
                taikhoan.trangThai = model.trangThai;
                _context.TaiKhoan.Update(taikhoan);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<int> TaoTaiKhoan(TaiKhoan model)
        {
            if (model != null)
            {
                var taiKhoan = new TaiKhoan()
                {
                    userName = model.userName,
                    passWord = model.passWord,
                    displayName = model.displayName,
                    trangThai = true,
                };
                _context.TaiKhoan.Add(taiKhoan);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public Task<TaiKhoan> ThongTinTaiKhoan(int Id)
        {
            return Task.FromResult(_context.TaiKhoan.Find(Id));
        }

        public async Task<int> XoaTaiKhoan(int Id)
        {
            var taiKhoan = _context.TaiKhoan.Where(c => c.Id == Id).FirstOrDefault();
            if (taiKhoan != null)
            {
                _context.Remove(taiKhoan);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

    }
}
