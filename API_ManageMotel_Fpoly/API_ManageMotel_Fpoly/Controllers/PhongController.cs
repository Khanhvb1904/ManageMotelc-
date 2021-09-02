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
    [Route("[Controller]/")]
    [ApiController]
    public class PhongController : ControllerBase
    {
        private IPhongService _iPhongService { get; set; }
        public PhongController(IPhongService phongService)
        {
            _iPhongService = phongService;
        }

        [HttpPost]
        [Route("TaoPhong")]
        public async Task<IActionResult> TaoPhong(Phong model)
        {
            if (model != null)
            {
               await _iPhongService.TaoPhong(model);
                return Content("Tạo thành công");
            }
            return NotFound("Tạo thất bại");
        }

       
        [HttpPatch]
        [Route("SuaPhong/{Id}")]
        public async Task<IActionResult> SuaPhong(int Id, Phong model)
        {
            if (model != null)
            {
                await _iPhongService.SuaPhong(Id, model);
                return Content("Sửa thành công");
            }
            return NotFound("Sửa thất bại");
        }

        
        [HttpDelete]
        [Route("XoaPhong/{Id}")]
        public async Task<IActionResult> XoaPhong(int Id)
        {
            if (Id > 0)
            {
                await _iPhongService.XoaPhong(Id);
                return Content("Xóa thành công!");
            }
            return NotFound("Không tìm thấy phòng cần xóa!");
        }

        
        [HttpGet]
        [Route("Phong/{Id}")]
        public async Task<Phong> LayThongTinPhong(int Id)
        {
            if (Id > 0)
            {
                return await _iPhongService.LayThongTinPhong(Id);
            }
            return null;

        }

        
        [HttpGet]
        [Route("DanhSachPhong")]
        public async Task<List<Phong>> DanhSachPhong()
        {
            return await _iPhongService.DanhSachPhong();
        }
    }
}
