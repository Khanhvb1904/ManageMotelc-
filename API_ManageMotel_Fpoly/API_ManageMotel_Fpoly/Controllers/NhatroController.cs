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
    public class NhatroController : ControllerBase
    {
        private IThongTinNhaTroServices _iThongTinNhaTroServices { get; set; }
        public NhatroController(IThongTinNhaTroServices nhaTroServices)
        {
            _iThongTinNhaTroServices = nhaTroServices;
        }

        [HttpGet]
        [Route("[controller]/getallinformotel")]
        public async Task<ActionResult<List<NhaTro>>> GetAllinforMotel()
        {
            Console.WriteLine(_iThongTinNhaTroServices.LayDanhSachNhatro());
            return await _iThongTinNhaTroServices.LayDanhSachNhatro();
        }

        [HttpPost]
        [Route("[controller]/createinforMotel")]
        public async Task<ActionResult<int>> CreateMotel(NhaTro nhaTro)
        {
            if (ModelState.IsValid)
            {
                return await _iThongTinNhaTroServices.ThemThongTinnhatro(nhaTro);

            }
            return NotFound("Thêm Dữ Liệu Không Thành Công");
        }

        [HttpPatch]
        [Route("[controller]/editinforMotel/{id}")]
        public async Task<ActionResult<int>> EditMotel(NhaTro nhaTro , int id)
        {
            var temp = _iThongTinNhaTroServices.laynhatro(id);

            if(temp != null)
            {
                nhaTro.Id = temp.Id;
                await _iThongTinNhaTroServices.SuaThongTinnhatro(nhaTro);
                return Ok("Sửa Thông Tin Thành Công");
            }

            return NotFound("Sửa Dữ Liệu Không Thành Công");
        }

        [HttpDelete]
        [Route("[controller]/deleteinfoMotel/{id}")]
        public async Task<ActionResult<NhaTro>> DeleteMotel(int id)
        {
            var nhatro = _iThongTinNhaTroServices.laynhatro(id);
            if (nhatro != null)
            {
                await _iThongTinNhaTroServices.Xoanhatro(nhatro);
                return Ok("Xóa Thành Công");
            }
            return NotFound("Xóa Không Thành Công");
        }


    }
}
