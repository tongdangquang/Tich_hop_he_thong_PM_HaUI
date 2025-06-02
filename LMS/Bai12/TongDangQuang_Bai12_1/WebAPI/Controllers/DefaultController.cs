using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
	public class DefaultController : ApiController
	{
		QLBanHangDB db = new QLBanHangDB();

		// Lấy danh sách sản phẩm
		[HttpGet]
		[Route("api/get_all_sanpham")]
		public List<SanPham> Get_all_sanpham()
		{
			return db.SanPham.ToList();
		}

		// Lấy danh sách danh mục
		[HttpGet]
		[Route("api/get_all_danhmuc")]
		public List<DanhMuc> Get_all_danhmuc()
		{
			return db.DanhMuc.ToList();
		}

		// Lấy danh sách sản phẩm theo danh mục
		[HttpGet]
		[Route("api/get_sanpham/{madanhmuc}")]
		public List<SanPham> Get_sanpham(int madanhmuc)
		{
			return db.SanPham.Where(x => x.MaDanhMuc == madanhmuc).ToList();
		}

		//Tìm danh sách Sản phẩm có đơn giá[a … b]
		[HttpGet]
		[Route("api/get_sanpham_by_gia/{a}/{b}")]
		public List<SanPham> Get_sanpham_by_gia(decimal a, decimal b)
		{
			return db.SanPham.Where(x => a <= x.DonGia && x.DonGia <= b).ToList();
		}

		// Lưu một danh mục 
		[HttpPost]
		[Route("api/post_danhmuc")]
		public bool Add_danhmuc([FromBody] DanhMuc dm)
		{
			DanhMuc old_dm = db.DanhMuc.SingleOrDefault(s => s.MaDanhMuc == dm.MaDanhMuc);

			if (old_dm == null)
			{
				db.DanhMuc.Add(dm);
				db.SaveChanges();
				return true;
			}
			return false;
		}

		// Sửa một danh mục
		[HttpPut]
		[Route("api/put_danhmuc")]
		public bool Update_danhmuc([FromBody] DanhMuc new_dm)
		{
			DanhMuc old_dm = db.DanhMuc.SingleOrDefault(s => s.MaDanhMuc == new_dm.MaDanhMuc);
			if (old_dm != null)
			{
				old_dm.TenDanhMuc = new_dm.TenDanhMuc;
				db.SaveChanges();
				return true;
			}
			return false;
		}

		// Xóa một danh mục
		[HttpDelete]
		[Route("api/delete_danhmuc/{ma}")]
		public bool Delete_danhmuc(int ma)
		{
			DanhMuc dm = db.DanhMuc.SingleOrDefault(s => s.MaDanhMuc == ma);
			if (dm != null)
			{
				db.DanhMuc.Remove(dm);
				db.SaveChanges();
				return true;
			}
			return false;
		}
	}
}
