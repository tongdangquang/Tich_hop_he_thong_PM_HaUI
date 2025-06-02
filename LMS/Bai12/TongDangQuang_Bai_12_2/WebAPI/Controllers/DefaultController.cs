using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
	public class DefaultController : ApiController
	{
		QLLuongDB db = new QLLuongDB();

		// hiển thị danh sách đơn vị
		[HttpGet]
		[Route("api/get_dv")]
		public List<DonVi> Get_dv()
		{
			return db.DonVi.ToList();
		}

		// thêm mới đơn vị vào bảng.
		[HttpPost]
		[Route("api/post_dv")]
		public bool Add_dv([FromBody]DonVi dv)
		{
			DonVi d = db.DonVi.SingleOrDefault(x => x.MaDonVi == dv.MaDonVi);
			if (d == null)
			{
				db.DonVi.Add(dv);
				db.SaveChanges();
				return true;
			}
			return false;
		}

		// sửa một đơn vị vào bảng.
		[HttpPut]
		[Route("api/put_dv")]
		public bool Update_dv([FromBody] DonVi dv)
		{
			DonVi d = db.DonVi.SingleOrDefault(x => x.MaDonVi == dv.MaDonVi);
			if (d != null)
			{
				d.TenDonVi = dv.TenDonVi;
				db.SaveChanges();
				return true;
			}
			return false;
		}


		// xóa một đơn vị vào bảng.
		[HttpDelete]
		[Route("api/delete_dv")]
		public bool Delete_dv(int madv)
		{
			DonVi d = db.DonVi.SingleOrDefault(x => x.MaDonVi == madv);
			if (d != null)
			{
				db.DonVi.Remove(d);
				db.SaveChanges();
				return true;
			}
			return false;
		}
	}
}
