using API_ManageMotel_Fpoly.EF.Entities;
using API_ManageMotel_Fpoly.EF.ManageMotelDbContext;
using API_ManageMotel_Fpoly.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.Services
{
    public class ThongTinNhaTroServices : IThongTinNhaTroServices
    {
        private readonly ManageMotelDbContext _context;
        public ThongTinNhaTroServices( ManageMotelDbContext context)
        {
            _context = context;
        }

        public Task<int> chitietnhatro(NhaTro nhaTro)
        {
            throw new NotImplementedException();
        }

        public Task<List<NhaTro>> LayDanhSachNhatro()
        {
            List<NhaTro> _LstNhatro = new List<NhaTro>();
            var lstnhatro = _context.NhaTro.ToList();
            if (lstnhatro.Count>=0)
            {
                foreach (var item in lstnhatro)
                {
                    _LstNhatro.Add(item);
                }
            }
            return Task.FromResult(_LstNhatro);
        }

        

        public async Task<int> SuaThongTinnhatro(NhaTro nhaTro)
        {
            var Suathongtin = _context.NhaTro.Where(c => c.Id == nhaTro.Id).FirstOrDefault();
            if (Suathongtin != null)
            {
                Suathongtin.name = nhaTro.name;
                Suathongtin.soTang = nhaTro.soTang;
                Suathongtin.soPhong = nhaTro.soPhong;
                Suathongtin.diaChi = nhaTro.diaChi;
                Suathongtin.ngayChotSo = nhaTro.ngayChotSo;
                Suathongtin.SDT = nhaTro.SDT;
                Suathongtin.moTa = nhaTro.moTa;
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<int> ThemThongTinnhatro(NhaTro nhaTro)
        {
            var themnhatro = new NhaTro()
            {
                name = nhaTro.name,
                soTang = nhaTro.soTang,
                soPhong = nhaTro.soPhong,
                diaChi = nhaTro.diaChi,
                ngayChotSo = nhaTro.ngayChotSo,
                SDT = nhaTro.SDT,
                moTa = nhaTro.moTa,
            };
            if (themnhatro != null)
            {
                _context.NhaTro.Add(themnhatro);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public NhaTro laynhatro(int id)
        {
            var nhatro = _context.NhaTro.Where(c => c.Id == id).FirstOrDefault();
            return nhatro;
        }

        public async Task<int> Xoanhatro(NhaTro nhaTro)
        {
            if (nhaTro != null)
            {
                _context.NhaTro.Remove(nhaTro);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
    }
}
