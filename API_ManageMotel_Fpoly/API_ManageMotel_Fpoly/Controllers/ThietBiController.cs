using API_ManageMotel_Fpoly.EF.Entities;
using API_ManageMotel_Fpoly.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.Controllers
{
    [Route("[controller]/")]
    [ApiController]
    public class ThietBiController : ControllerBase
    {
        private readonly ITrangThietBiService _iTrangThietBiService;
        public ThietBiController(ITrangThietBiService iTrangThietBiService)
        {
            _iTrangThietBiService = iTrangThietBiService;
        }
        [HttpGet]
        [Route("DanhSachLoaiThietBi")]
        public Task<List<LoaiThietBi>> DanhSachLoaiThietBi()
        {
            return _iTrangThietBiService.DanhSachLoaiThietBi();
        }
             
        [HttpGet]
        [Route("DanhSachThietBi")]
        public Task<List<TrangThietBi>> DanhSachThietBi()
        {
           return _iTrangThietBiService.DanhSachThietBi();
        }
        
        [HttpGet]
        [Route("ThongTinLoaiThietBi/{Id}")]
        public Task<LoaiThietBi> ThongTinLoaiThietBi(int Id)
        {
            return _iTrangThietBiService.ThongTinLoaiThietBi(Id);
        }

        [HttpGet]
        [Route("ThongTinThietBi/{Id}")]
        public Task<TrangThietBi> ThongTinThietBi(int Id)
        {
            return _iTrangThietBiService.ThongTinThietBi(Id);
        }

        [HttpPost]
        [Route("TaoLoaiThietBi")]
        public async Task<IActionResult> TaoLoaiThietBi(LoaiThietBi model)
        {
            if (ModelState.IsValid)
            {
                await _iTrangThietBiService.TaoLoaiThietBi(model);
                return Content("Tạo thành công!");
            }
            return NotFound("Tạo thất bại!");
        }

        [HttpPost]
        [Route("TaoThietBi")]
        public async Task<IActionResult> TaoThietBi(TrangThietBi model)
        {
            if (ModelState.IsValid)
            {
                await _iTrangThietBiService.TaoThietBi(model);
                return Content("Tạo thiết bị thành công!");
            }
            return NotFound("Tạo thất bại!");
        }

        [HttpPatch]
        [Route("SuaLoaiThietBi/{Id}")]
        public async Task<IActionResult> SuaLoaiThietBi(int Id,LoaiThietBi model)
        {
            var loaiThietBi = await _iTrangThietBiService.ThongTinLoaiThietBi(Id);
            if (ModelState.IsValid)
            {
                if (loaiThietBi != null)
                {
                    await _iTrangThietBiService.SuaLoaiThietBi(Id, model);
                    return Content("Sửa thành công!");
                }
                return NotFound("Không tìm thấy loại thiết bị!");
            }
            return NotFound("Sửa thất bại!");
        }

        [HttpPatch]
        [Route("SuaThietBi/{Id}")]
        public async Task<IActionResult> SuaThietBi(int Id, TrangThietBi model)
        {
            var thietBi = await _iTrangThietBiService.ThongTinThietBi(Id);
            if (ModelState.IsValid)
            {
                if (thietBi != null)
                {
                    await _iTrangThietBiService.SuaThietBi(Id, model);
                    return Content("Sửa thành công!");

                }
                return NotFound("Không tìm thấy!");
            }
            return NotFound("Sửa thất bại!");
        }

        [HttpDelete]
        [Route("XoaLoaiThietBi/{Id}")]
        public async Task<IActionResult> XoaLoaiThietBi(int Id)
        {
            var loaiThietBi = await _iTrangThietBiService.ThongTinLoaiThietBi(Id);
            if (loaiThietBi != null)
            {
                await _iTrangThietBiService.XoaLoaiThietBi(Id);
                return Content("Xóa thành công!");
            }
            return NotFound("Xóa thất bại!");
        }

        [HttpDelete]
        [Route("XoaThietBi/{Id}")]
        public async Task<IActionResult> XoaThietBi(int Id)
        {
            var thietBi = await _iTrangThietBiService.ThongTinThietBi(Id);
            if (thietBi != null)
            {
                await _iTrangThietBiService.XoaThietBi(Id);
                return Content("Xóa thành công!");
            }
            return NotFound("Không tìm thấy!");
        }


    }
}
