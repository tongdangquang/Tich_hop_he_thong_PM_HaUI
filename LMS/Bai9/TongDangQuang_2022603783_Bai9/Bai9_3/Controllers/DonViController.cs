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
	}
}
