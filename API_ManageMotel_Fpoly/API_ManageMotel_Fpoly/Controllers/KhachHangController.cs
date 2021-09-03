using API_ManageMotel_Fpoly.EF.Entities;
using API_ManageMotel_Fpoly.IServices;
using API_ManageMotel_Fpoly.Models;
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
    public class KhachHangController : ControllerBase
    {
        private IKhachHangServices _iKhachHangServices { get; set; }

        public KhachHangController(IKhachHangServices iKhachHangServices)
        {
            _iKhachHangServices = iKhachHangServices;
        }
        [HttpGet]
        [Route("[controller]/getallinforCustomer")]
        public async Task<ActionResult<List<FullinfoCustomer>>> GetAllinforCustomer()
        {
            Console.WriteLine(_iKhachHangServices.LayDanhSachKhachHang());
            return await _iKhachHangServices.LayDanhSachKhachHang();
        }
        [HttpPost]
        [Route("[controller]/addinfocustomer")]
        public async Task<ActionResult<int>> addinfocustomer(KhachHang khach, Xe xe, LoaiXe loaiXe)
        {
            if (ModelState.IsValid)
            {
                return await _iKhachHangServices.ThemThongTinKhachHang(khach, xe, loaiXe);

            }
            return NotFound("Thêm Dữ Liệu Không Thành Công");
        }
    }
}
