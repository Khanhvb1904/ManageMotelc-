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
        #region Lấy Thông Tin Khách Hàng
        [HttpGet]
        [Route("[controller]/getallinforCustomer")]
        public async Task<ActionResult<List<FullinfoCustomer>>> GetAllinforCustomer()
        {
            Console.WriteLine(_iKhachHangServices.LayDanhSachFullKhachHang());
            return await _iKhachHangServices.LayDanhSachFullKhachHang();
        }

        [HttpGet]
        [Route("[controller]/getinforCustomer")]
        public async Task<ActionResult<List<KhachHang>>> GetinforCustomer()
        {
            Console.WriteLine(_iKhachHangServices.LayDanhSachKhachHang());
            return await _iKhachHangServices.LayDanhSachKhachHang();
        }

        [HttpGet]
        [Route("[controller]/getinfoCarriagerCustomer")]
        public async Task<ActionResult<List<Xe>>> GetinfoCarriagerCustomer()
        {
            Console.WriteLine(_iKhachHangServices.LayDanhSachXeKhachHang());
            return await _iKhachHangServices.LayDanhSachXeKhachHang();
        }

        [HttpGet]
        [Route("[controller]/getinfoCategoryCarriagerCustomer")]
        public async Task<ActionResult<List<LoaiXe>>> GetinfoCategoryCarriagerCustomer()
        {
            Console.WriteLine(_iKhachHangServices.LayDanhSachLoaiKhachHang());
            return await _iKhachHangServices.LayDanhSachLoaiKhachHang();
        }
        #endregion

        #region Thêm Thông Tin Khách Hàng
        [HttpPost]
        [Route("[controller]/addinfocustomer")]
        public async Task<ActionResult<int>> Addinfocustomer(KhachHang khach)
        {
            if (ModelState.IsValid)
            {
                return await _iKhachHangServices.ThemThongTinKhachHang(khach);

            }
            return NotFound("Thêm Dữ Liệu Không Thành Công");
        }

        [HttpPost]
        [Route("[controller]/addinfoCarriageofcustomer")]
        public async Task<ActionResult<int>> Addinfocarriageofcustomer(Xe xe)
        {
            if (ModelState.IsValid)
            {
                return await _iKhachHangServices.ThemThongTinXeKhachHang(xe);
            }
            return NotFound("Thêm Dữ Liệu Không Thành Công");
        }

        [HttpPost]
        [Route("[controller]/addinfoCategoryofcustomer")]
        public async Task<ActionResult<int>> AddinfoCategoryofcustomer(LoaiXe loaiXe)
        {
            if (ModelState.IsValid)
            {
                return await _iKhachHangServices.ThemThongTinLoaiXeKhachHang(loaiXe);
            }
            return NotFound("Thêm Dữ Liệu Không Thành Công");
        }
        #endregion

        #region Sửa thông tin khách hàng
        [HttpPut]
        [Route("[controller]/editinforCustomer/{id}")]
        public async Task<ActionResult<int>> EditinforCustomer(KhachHang khach, int id)
        {
            var temp = _iKhachHangServices.layidkhachhang(id);
            if (temp != null)
            {
                khach.Id = temp.Id;
                await _iKhachHangServices.SuaThongTinKhachHang(khach);
                return Ok("Sửa Thông Tin Thành Công");
            }
            return NotFound("Sửa Không Thành Công");
        }

        [HttpPut]
        [Route("[controller]/editinforCarriageofcustomer/{id}")]
        public async Task<ActionResult<int>> EditinforCarriageofcustomer(Xe xe, int id)
        {
            var temp = _iKhachHangServices.layidXekhachhang(id);
            if (temp != null)
            {
                xe.Id = temp.Id;
                await _iKhachHangServices.SuaThongTinXeKhachHang(xe);
                return Ok("Sửa Thông Tin Thành Công");
            }
            return NotFound("Sửa Không Thành Công");
        }

        [HttpPut]
        [Route("[controller]/EditinforCategoryCarriageofcustomer/{id}")]
        public async Task<ActionResult<int>> EditinforCategoryCarriageofcustomer(LoaiXe loaiXe, int id)
        {
            var temp = _iKhachHangServices.layidLoaiXekhachhang(id);
            if (temp != null)
            {
                loaiXe.Id = temp.Id;
                await _iKhachHangServices.SuaThongTinLoaiXeKhachHang(loaiXe);
                return Ok("Sửa Thông Tin Thành Công");
            }
            return NotFound("Sửa Không Thành Công");
        }
        #endregion

        #region Xóa thông tin khách hàng
        [HttpDelete]
        [Route("[controller]/deleteinfoCustomer/{id}")]
        public async Task<ActionResult<int>> DeleteinfoCustomer(int id)
        {
            var khach = _iKhachHangServices.layidkhachhang(id);
            if (khach != null)
            {
                await _iKhachHangServices.XoaThongTinKhachHang(khach);
                return Ok("Xóa Thành Công");
            }
            return NotFound("Xóa Không Thành Công");
        }
        [HttpDelete]
        [Route("[controller]/deleteinfoCarriageofCustomer/{id}")]
        public async Task<ActionResult<int>> DeleteinfoCarriageofCustomer(int id)
        {
            var xe = _iKhachHangServices.layidXekhachhang(id);
            if (xe != null)
            {
                await _iKhachHangServices.XoaThongTinXeKhachHang(xe);
                return Ok("Xóa Thành Công");
            }
            return NotFound("Xóa Không Thành Công");
        }
        [HttpDelete]
        [Route("[controller]/deleteinfoCategoryCarriageofCustomer/{id}")]
        public async Task<ActionResult<int>> DeleteinfoCategoryCarriageofCustomer(int id)
        {
            var loaixe = _iKhachHangServices.layidLoaiXekhachhang(id);
            if (loaixe != null)
            {
                await _iKhachHangServices.XoaThongTinLoaiXeKhachHang(loaixe);
                return Ok("Xóa Thành Công");
            }
            return NotFound("Xóa Không Thành Công");
        }
        #endregion
        
    }
}
