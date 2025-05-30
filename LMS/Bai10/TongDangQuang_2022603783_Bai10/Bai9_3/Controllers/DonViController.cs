using Bai9_3.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai9_3.Controllers
{
    public class DonViController : ApiController
    {
		QLLuong db = new QLLuong();

		// Lưu một đơn vị(DonViController.cs)
		[HttpPost]
		[Route("api/add_dv")]
		public List<DonVi> Add_donvi([FromBody] DonVi dv)
		{
			if(db.DonVi.SingleOrDefault(d=> d.MaDonVi == dv.MaDonVi) == null)
			{
				db.DonVi.Add(dv);
				db.SaveChanges();
				return db.DonVi.ToList();
			}
			return null;
		}

		// Sửa một đơn vị(DonViController.cs)
		[HttpPut]
		[Route("api/update_dv")]
		public List<DonVi> Update_donvi([FromBody] DonVi new_dv)
		{
			DonVi old_dv = db.DonVi.SingleOrDefault(d => d.MaDonVi == new_dv.MaDonVi);
			if (old_dv != null)
			{
				old_dv.TenDonVi = new_dv.TenDonVi;
				db.SaveChanges();
				return db.DonVi.ToList();
			}
			return null;
		}

		// Xóa một đơn vị(DonViController.cs)
		[HttpDelete]
		[Route("api/delete_dv")]
		public List<DonVi> Delete_donvi(int madv)
		{
			DonVi dv = db.DonVi.SingleOrDefault(d => d.MaDonVi == madv);
			if (dv != null)
			{
				db.DonVi.Remove(dv);
				db.SaveChanges();
				return db.DonVi.ToList();
			}
			return null;
		}
	}
}
