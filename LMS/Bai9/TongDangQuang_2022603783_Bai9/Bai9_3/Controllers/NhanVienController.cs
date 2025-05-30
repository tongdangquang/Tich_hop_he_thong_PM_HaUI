using Bai9_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai9_3.Controllers
{
    public class NhanVienController : ApiController
    {
		QLLuong db = new QLLuong();

		// Lưu một nhân viên(NhanVienController.cs)
		[HttpPost]
		[Route("api/add_nv")]
		public List<NhanVien> Add_nhanvien([FromBody] NhanVien nv)
		{
			if (db.NhanVien.SingleOrDefault(n => n.Ma == nv.Ma) == null)
			{
				db.NhanVien.Add(nv);
				db.SaveChanges();
				return db.NhanVien.ToList();
			}
			return null;
		}
	}
}
