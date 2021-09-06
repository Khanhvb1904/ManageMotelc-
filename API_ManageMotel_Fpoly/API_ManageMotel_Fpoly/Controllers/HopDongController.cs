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
    [Route("api/")]
    [ApiController]
    public class HopDongController : ControllerBase
    {
        public IHopDongServices _ihopDongServices { get; set; }

        public HopDongController(IHopDongServices ihopDongServices)
        {
            _ihopDongServices = ihopDongServices;
        }

        [HttpGet]
        [Route("[controller]/getallcontract")]
        public async Task<ActionResult<List<HopDong>>> Getallcontract()
        {
            Console.WriteLine(_ihopDongServices.LayDanhSachHopDong());
            return await _ihopDongServices.LayDanhSachHopDong();
        }

        [HttpPost]
        [Route("[controller]/CreateContract")]
        public async Task<ActionResult<int>> createcontract(HopDong hopDong)
        {
            if (ModelState.IsValid)
            {
                return await _ihopDongServices.ThemHopDong(hopDong);
            }
            return NotFound("Thêm Dữ Liệu Thành Công");
        }

        [HttpPut]
        [Route("[controller]/editContract/{id}")]
        public async Task<ActionResult<int>> EditContract(HopDong hopDong , int id)
        {
            var tmp = _ihopDongServices.layidhopdong(id);
            if (tmp != null)
            {
                hopDong.Id = tmp.Id;
                await _ihopDongServices.SuaThongTinHopDong(hopDong);
                return Ok("Sửa Thông Tin Thành Công");
            }
            return NotFound("Sửa Thông Tin Không Thành Công");
        }
        [HttpDelete]
        [Route("[controller]/deleteContract/{id}")]
        public async Task<ActionResult<int>> DeleteContract( int id)
        {
            var hopdong = _ihopDongServices.layidhopdong(id);
            if (hopdong != null)
            {
                await _ihopDongServices.XoaHopDong(hopdong);
                return Ok("Xóa Hợp Đồng Thành Công");
            }
            return NotFound("Xóa Hợp Đồng Không Thành Công");
        }
    }
}
