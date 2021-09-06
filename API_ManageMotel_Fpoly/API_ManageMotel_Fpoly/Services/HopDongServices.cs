using API_ManageMotel_Fpoly.EF.Entities;
using API_ManageMotel_Fpoly.EF.ManageMotelDbContext;
using API_ManageMotel_Fpoly.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.Services
{
    public class HopDongServices : IHopDongServices
    {
        private readonly ManageMotelDbContext _contex;

        public HopDongServices(ManageMotelDbContext contex)
        {
            _contex = contex;
        }

        public  Task<List<HopDong>> LayDanhSachHopDong()
        {
            List<HopDong> _LsthopDongs = new List<HopDong>();
            var Lsthopdong = _contex.HopDong.ToList();
            if (Lsthopdong.Count >= 0)
            {
                foreach (var item in Lsthopdong)
                {
                    _LsthopDongs.Add(item);
                }
            }
            return Task.FromResult(_LsthopDongs);
        }

        public async Task<int> SuaThongTinHopDong(HopDong hopDong)
        {
            var suathongtinhopdong = _contex.HopDong.Where(c => c.Id == hopDong.Id).FirstOrDefault();
            if (suathongtinhopdong != null)
            {
                suathongtinhopdong.maKhachHang = hopDong.maKhachHang;
                suathongtinhopdong.ngayTao = hopDong.ngayTao;
                suathongtinhopdong.ngayKiKet = hopDong.ngayKiKet;
                suathongtinhopdong.ngayHetHan = hopDong.ngayHetHan;
                await _contex.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<int> ThemHopDong( HopDong hopDong)
        {
            var themhopdong = new HopDong
            {
                maKhachHang = hopDong.maKhachHang,
                ngayTao = hopDong.ngayTao,
                ngayKiKet = hopDong.ngayKiKet,
                ngayHetHan = hopDong.ngayHetHan,
            };
            if (themhopdong !=null)
            {
                _contex.HopDong.Add(themhopdong);
                await _contex.SaveChangesAsync();
                return 0;
            }
            return 1;
        }

        public HopDong layidhopdong(int id)
        {
            var layid = _contex.HopDong.Where(c => c.Id == id).FirstOrDefault();
            return layid; 
        }

        public async Task<int> XoaHopDong(HopDong hopDong)
        {
            if (hopDong != null)
            {
                _contex.HopDong.Remove(hopDong);
                await _contex.SaveChangesAsync();
                return 0;
            }
            return 1;
        }
    }
}
