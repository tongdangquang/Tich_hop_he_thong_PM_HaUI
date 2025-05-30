using Bai9_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai9_3.Controllers
{
	public class DefaultController : ApiController
	{
		QLLuong db = new QLLuong();

		// 9.3.1: Dùng HttpGet tạo các Web API để: 
		// Lấy toàn bộ danh sách nhân viên 
		[HttpGet]
		[Route("api/get_all_nv")]
		public List<NhanVien> Get_all_nv()
		{
			return db.NhanVien.ToList();
		}

		// Lấy chi tiết 1 nhân viên 
		[HttpGet]
		[Route("api/get_nv")]
		public NhanVien Get_nv(int ma)
		{
			NhanVien nv = db.NhanVien.SingleOrDefault(n => n.Ma == ma);
			return nv;
		}

		// Lấy danh sách nhân viên theo đơn vị 
		[HttpGet]
		[Route("api/get_nv_by_dv")]
		public List<NhanVien> Get_nv_by_dv(int madv)
		{
			List<NhanVien> nv_lst = db.NhanVien.Where(nv => nv.MaDonVi == madv).ToList();
			return nv_lst;
		}

		// Lấy danh sách nhân viên theo giới tính 
		[HttpGet]
		[Route("api/get_nv_by_gender")]
		public List<NhanVien> Get_nv_by_gender(string gender)
		{
			List<NhanVien> nv_lst = db.NhanVien.Where(nv => nv.GioiTinh == gender).ToList();
			return nv_lst;
		}

		// Tìm danh sách nhân viên có hệ số lương trong khoảng[a … b] 
		[HttpGet]
		[Route("api/get_nv_by_luong")]
		public List<NhanVien> Get_nv_by_luong(double a, double b)
		{
			List<NhanVien> nv_lst = db.NhanVien.Where(nv => (a <= nv.Hsluong) && (nv.Hsluong <= b)).ToList();
			return nv_lst;
		}

		// Lấy toàn bộ danh sách đơn vị 
		[HttpGet]
		[Route("api/get_all_dv")]
		public List<DonVi> Get_all_dv()
		{
			List<DonVi> dv_lst = db.DonVi.ToList();
			return dv_lst;
		}

		// Lấy chi tiết 1 đơn vị 
		[HttpGet]
		[Route("api/get_dv")]
		public DonVi Get_dv(int madv)
		{
			DonVi dv = db.DonVi.SingleOrDefault(d => d.MaDonVi == madv);
			return dv;
		}
	}
}
