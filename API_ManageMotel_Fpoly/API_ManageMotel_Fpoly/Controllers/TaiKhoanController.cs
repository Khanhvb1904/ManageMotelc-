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
    public class TaiKhoanController : ControllerBase
    {
        private readonly ITaiKhoanService _iTaiKhoanService;
        public TaiKhoanController(ITaiKhoanService iTaiKhoanService)
        {
            _iTaiKhoanService = iTaiKhoanService;
        }

        [HttpGet]
        [Route("DanhSachTaiKhoan")]
        public Task<List<TaiKhoan>> DanhSachTaiKhoan()
        {
            return _iTaiKhoanService.DanhSachTaiKhaon();
        }

        [HttpGet]
        [Route("ThongTinTaiKhoan/{Id}")]
        public Task<TaiKhoan> ThongTinTaiKhoan(int Id)
        {
            return _iTaiKhoanService.ThongTinTaiKhoan(Id);
        }

        [HttpPost]
        [Route("TaoTaiKhoan")]
        public async Task<IActionResult> TaoTaiKhoan(TaiKhoan model)
        {
            if (model != null)
            {
                await _iTaiKhoanService.TaoTaiKhoan(model);
                return Content("Tao Thanh Cong!");
            }
            return NotFound("Tao That Bai!");
        }

        [HttpPatch]
        [Route("SuaTaiKhoan/{Id}")]
        public async Task<IActionResult> SuaTaiKhoan(int Id, TaiKhoan model)
        {
            if (ModelState.IsValid)
            {
                await _iTaiKhoanService.SuaTaiKhoan(Id, model);
                return Content("Sua Thanh Cong!");
            }
            return NotFound("Sua That Bai!");
        }

        [HttpDelete]
        [Route("XoaTaiKhoan/{Id}")]
        public async Task<IActionResult> XoaTaiKhoan(int Id)
        {
            var taiKhoan = await _iTaiKhoanService.ThongTinTaiKhoan(Id);
            if (taiKhoan != null)
            {
                await _iTaiKhoanService.XoaTaiKhoan(Id);
                return Content("Xoa Thanh Cong!");
            }
            return NotFound("Khong Tim Thay Tai Khoan!");
        }
    }
}
