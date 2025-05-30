using Bai9_2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai9_2.Controllers
{
	public class DefaultController : ApiController
	{
		QlbanHang db = new QlbanHang();
		// 9.2.1 Dùng HttpPost tạo Web API để lưu 1 danh mục.
		[HttpPost]
		[Route("api/add_dm")]
		public List<DanhMuc> Add_dm([FromBody] DanhMuc dm)
		{
			try
			{
				if (dm != null)
				{
					db.DanhMuc.Add(dm);
					db.SaveChanges();
					return db.DanhMuc.ToList();
				}
				return null;
			}
			catch
			{
				return null;
			}
		}

		// 9.2.2 Dùng HtttpPut tạo Web API để sửa 1 danh mục. 
		[HttpPut]
		[Route("api/update_dm")]
		public List<DanhMuc> Update_dm([FromBody] DanhMuc new_dm)
		{
			try
			{
				DanhMuc old_dm = db.DanhMuc.SingleOrDefault(dm => dm.MaDanhMuc == new_dm.MaDanhMuc);
				if (old_dm != null)
				{
					old_dm.TenDanhMuc = new_dm.TenDanhMuc;
					db.SaveChanges();
					return db.DanhMuc.ToList();
				}
				return null;
			}
			catch
			{
				return null;
			}
		}

		// 9.2.3 Dùng HttpDelete tạo Web API để xóa 1 danh mục.
		[HttpDelete]
		[Route("api/delete_dm")]
		public List<DanhMuc> Delete_dm(int madm)
		{
			try
			{
				DanhMuc old_dm = db.DanhMuc.SingleOrDefault(dm => dm.MaDanhMuc == madm);
				if (old_dm != null)
				{
					db.DanhMuc.Remove(old_dm);
					db.SaveChanges();
					return db.DanhMuc.ToList();
				}
				return null;
			}
			catch
			{
				return null;
			}
		}

	}
}
