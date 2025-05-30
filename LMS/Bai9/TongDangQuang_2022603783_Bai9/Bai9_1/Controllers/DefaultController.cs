using Bai9_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai9_1.Controllers
{
    public class DefaultController : ApiController
    {
		QLBanHang db = new QLBanHang();

		// Lấy toàn bộ danh mục sản phẩm
		[HttpGet]
		[Route("api/get_list_dm")]
		public List<DanhMuc> Get_All_DanhMuc()
		{
			return db.DanhMuc.ToList();
		}

		// Lấy chi tiết 1 một danh mục sản phẩm theo mã danh mục
		[HttpGet]
		[Route("api/get_dm")]
		public DanhMuc Get_DanhMuc(int madm)
		{
			return db.DanhMuc.SingleOrDefault(dm => dm.MaDanhMuc == madm);
		}
	}
}
