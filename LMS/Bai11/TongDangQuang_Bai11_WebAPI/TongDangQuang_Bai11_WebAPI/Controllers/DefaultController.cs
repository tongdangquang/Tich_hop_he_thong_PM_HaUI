using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TongDangQuang_Bai11_WebAPI.Models;

namespace TongDangQuang_Bai11_WebAPI.Controllers
{
    public class DefaultController : ApiController
    {
        QLLuong data = new QLLuong();

        // 11.1. lấy toàn bộ danh sách nhân viên
        [HttpGet]
        [Route("api/get_all_nv")]
        public List<NhanVien> Get_all_nv()
        {
            return data.NhanVien.ToList();
        }

		// 11.2. lấy ra chi tiết 1 nhân viên theo mã nhân viên
		[HttpGet]
		[Route("api/get_nv_by_ma")]
		public NhanVien Get_nv_by_ma(int ma)
		{
			return data.NhanVien.SingleOrDefault(x => x.Ma == ma);
		}

		// 11.3. lấy danh sách nhân viên theo đơn vị
		[HttpGet]
		[Route("api/get_nv_by_donvi")]
		public List<NhanVien> Get_nv_by_donvi(int madonvi)
		{
			return data.NhanVien.Where(x => x.MaDonVi == madonvi).ToList();
		}

		// 11.4. lấy danh sách nhân viên theo giới tính
		[HttpGet]
		[Route("api/get_nv_by_gioitinh")]
		public List<NhanVien> Get_nv_by_gioitinh(string gender)
		{
			return data.NhanVien.Where(x => x.GioiTinh == gender).ToList();
		}

		// 11.5. lấy danh sách nhân viên có hệ số lương khoảng [a...b]
		[HttpGet]
		[Route("api/get_nv_by_luong")]
		public List<NhanVien> Get_nv_by_luong(double a, double b)
		{
			return data.NhanVien.Where(x => a <= x.Hsluong && x.Hsluong <= b).ToList();
		}

		// 11.6. lấy toàn bộ danh sách đơn vị
		[HttpGet]
		[Route("api/get_all_dv")]
		public List<DonVi> Get_all_dv()
		{
			return data.DonVi.ToList();
		}

		// 11.7. lấy chi tiết một đơn vị
		[HttpGet]
		[Route("api/get_dv_by_madv")]
		public DonVi Get_dv_by_madv(int madv)
		{
			return data.DonVi.SingleOrDefault(x => x.MaDonVi == madv);
		}


	}
}
