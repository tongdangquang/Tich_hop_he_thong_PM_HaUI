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

		// Sửa một nhân viên (NhanVienController.cs) 
		[HttpPut]
		[Route("api/update_nv")]
		public List<NhanVien> Update_nhanvien([FromBody] NhanVien new_nv)
		{
			try
			{
				NhanVien old_nv = db.NhanVien.SingleOrDefault(n => n.Ma == new_nv.Ma);
				if (old_nv != null)
				{
					old_nv.HoTen = new_nv.HoTen;
					old_nv.NgaySinh = new_nv.NgaySinh;
					old_nv.GioiTinh = new_nv.GioiTinh;
					old_nv.Hsluong = new_nv.Hsluong;
					old_nv.MaDonVi = new_nv.MaDonVi;
					db.SaveChanges();
					return db.NhanVien.ToList();
				}
				return null;
			}
			catch
			{
				return null;
			}
		}

		// Xóa một nhân viên (NhanVienController.cs) 
		[HttpDelete]
		[Route("api/delete_nv")]
		public List<NhanVien> Delete_nhanvien(int manv)
		{
			NhanVien nv = db.NhanVien.SingleOrDefault(n => n.Ma == manv);
			if (nv != null)
			{
				db.NhanVien.Remove(nv);
				db.SaveChanges();
				return db.NhanVien.ToList();
			}
			return null;
		}
	}
}
