using API_ManageMotel_Fpoly.EF.Entities;
using API_ManageMotel_Fpoly.EF.ManageMotelDbContext;
using API_ManageMotel_Fpoly.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.Services
{
    public class PhongService : IPhongService
    {
        private readonly ManageMotelDbContext _context;
        public PhongService(ManageMotelDbContext context)
        {
            _context = context;
        }
        public Task<Phong> LayThongTinPhong(int Id)
        {
            var phong = _context.Phong.Where(c => c.Id == Id).FirstOrDefault();
            if (phong != null)
            {
                return Task.FromResult(phong);
            }
            return null;
        }

        public async Task<int> SuaPhong(int Id, Phong model)
        {
            var phong = _context.Phong.Where(c => c.Id == Id).FirstOrDefault();
            if (phong != null)
            {
                phong.maNhaTro = model.maNhaTro;
                phong.maLoaiPhong = model.maLoaiPhong;
                phong.soPhong = model.soPhong;
                phong.giaPhong = model.giaPhong;
                phong.moTa = model.moTa;
                phong.sucChua = model.sucChua;
                phong.dienTich = model.dienTich;
                phong.ngayPhongSeTrong = model.ngayPhongSeTrong;
                phong.trangThai = model.trangThai;
                _context.Phong.Update(phong);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<int> TaoPhong(Phong model)
        {
            if (model != null)
            {
                _context.Phong.Add(model);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<int> XoaPhong(int Id)
        {
            var phong = _context.Phong.Where(c => c.Id == Id).FirstOrDefault();
            if (phong!=null){
                _context.Phong.Remove(phong);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<List<Phong>> DanhSachPhong()
        {
            var lstPhong = new List<Phong>();
            var lstPhong_linQ = _context.Phong.ToList();
            if (lstPhong_linQ.Count > 0)
            {
                foreach(var item in lstPhong_linQ)
                {
                    lstPhong.Add(item);
                }
            }
            return await Task.FromResult(lstPhong);
        }
    }
}
