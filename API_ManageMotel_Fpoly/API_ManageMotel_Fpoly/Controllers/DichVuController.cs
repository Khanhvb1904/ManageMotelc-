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
    public class DichVuController : ControllerBase
    {
        private readonly IDichVuService _iDichVuSerVice;
        public DichVuController(IDichVuService iDichVuService)
        {
            _iDichVuSerVice = iDichVuService;
        }

        [HttpGet]
        [Route("DanhSachDichVu")]
        public Task<List<DichVu>> DanhSachDichVu()
        {
            return _iDichVuSerVice.DanhSachDichVu();
        }

        [HttpGet]
        [Route("ThongTinDichVu/{Id}")]
        public Task<DichVu> ThongTinDichVu(int Id)
        {
            return _iDichVuSerVice.ThongTinDichVu(Id);
        }

        [HttpGet]
        [Route("DanhSachLoaiDichVu")]
        public Task<List<LoaiDichVu>> DanhSachLoaiDichVu()
        {
            return _iDichVuSerVice.DanhSachLoaiDichVu();
        }

        [HttpGet]
        [Route("ThongTinLoaiDichVu/{Id}")]
        public Task<LoaiDichVu> ThongTinLoaiDichVu(int Id)
        {
            return _iDichVuSerVice.ThongTinLoaiDichVu(Id);
        }


        [HttpPost]
        [Route("TaoDichVu")]
        public async Task<IActionResult> TaoDichVu(DichVu model)
        {
            if (ModelState.IsValid)
            {
                await _iDichVuSerVice.TaoDichVu(model);
                return Content("Tạo thành công!");
            }
            return NotFound("Tạo thất bại!");
        }

        [HttpPost]
        [Route("TaoLoaiDichVu")]
        public async Task<IActionResult> TaoLoaiDichVu(LoaiDichVu model)
        {
            if (ModelState.IsValid)
            {
                await _iDichVuSerVice.TaoLoaiDichVu(model);
                return Content("Tạo thành công!");
            }
            return NotFound("Tạo thất bại!");
        }

        [HttpPatch]
        [Route("SuaDichVu/{Id}")]
        public async Task<IActionResult> SuaDichVu(int Id, DichVu model)
        {
            var dichVu = await _iDichVuSerVice.ThongTinDichVu(Id);
            if (ModelState.IsValid)
            {
                if (dichVu != null)
                {
                    await _iDichVuSerVice.SuaDichVu(Id, model);
                    return Content("Sửa thành công!");
                }
                return NotFound("Không tìm thấy!");
            }
            return NotFound("Sửa thất bại!");
        }

        [HttpPatch]
        [Route("SuaLoaiDichVu/{Id}")]
        public async Task<IActionResult> SuaLoaiDichVu(int Id, LoaiDichVu model)
        {
            var loaiDichVu = await _iDichVuSerVice.ThongTinLoaiDichVu(Id);
            if (ModelState.IsValid)
            {
                if (loaiDichVu != null)
                {
                    await _iDichVuSerVice.SuaLoaiDichVu(Id, model);
                    return Content("Sửa thành công!");

                }
                return NotFound("Không tìm thấy!");
            }
            return NotFound("Sửa thất bại!");
        }

        [HttpDelete]
        [Route("XoaDichVu/{Id}")]
        public async Task<IActionResult> XoaDichVu(int Id)
        {
            var dichVu = await _iDichVuSerVice.ThongTinDichVu(Id);
            if (dichVu != null)
            {
                await _iDichVuSerVice.XoaDichVu(Id);
                return Content("Xóa thành công!");
            }
            return NotFound("Không tìm thấy!");
        }

        [HttpDelete]
        [Route("XoaLoaiDichVu/{Id}")]
        public async Task<IActionResult> XoaLoaiDichVu(int Id)
        {
            var loaiDichVu = await _iDichVuSerVice.ThongTinLoaiDichVu(Id);
            if (loaiDichVu != null)
            {
                await _iDichVuSerVice.XoaLoaiDichVu(Id);
                return Content("Xóa thành công!");
            }
            return NotFound("Xóa thất bại!");
        }
    }

}
