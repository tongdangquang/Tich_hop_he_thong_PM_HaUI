using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEP_API_DATABASE.Models;

namespace WEP_API_DATABASE.Controllers
{
    public class DefaultController : ApiController
    {
        Truonghoc db = new Truonghoc();

        // 1. [HttpGet]: dùng để lấy ra dữ liệu
        // lấy ra toàn bộ danh sách sinh viên
        [HttpGet]
        [Route("api/th/get_sinhvien")]
        public List<sinhvien> GetAllSinhvien()
        {
            return db.sinhvien.ToList();
        }

		// lấy ra toàn bộ danh sách lớp học
		[HttpGet]
		[Route("api/th/get_lophoc")]
		public List<lophoc> GetAllLophoc()
		{
			return db.lophoc.ToList();
		}

		// lấy ra danh sách sinh viên theo mã lớp
		[HttpGet]
        [Route("api/th/get_by_malop")]
        public List<sinhvien> Get_by_malop(int malop)
        {
            return db.sinhvien.Where(sv => sv.malop == malop).ToList();
        }

		// tìm sinh viên theo mã sinh viên
		[HttpGet]
		[Route("api/th/get_by_masv")]
		public sinhvien Get_by_masv(int masv)
		{
			return db.sinhvien.SingleOrDefault(sv => sv.masv == masv);
		}

        // 2. [HttpPost]: dùng để thêm dữ liệu vào cơ sở dữ liệu
        [HttpPost]
		[Route("api/th/post_add")]
        public List<sinhvien> Themsinhvien([FromBody] sinhvien sv)
        {
            try
            {
                db.sinhvien.Add(sv);
                db.SaveChanges();
			    return db.sinhvien.ToList();
            }
            catch
            {
                return null;
            }
		}

        // 3. [HttpPut]: dùng để cập nhật dữ liệu
        [HttpPut]
        [Route("api/th/put_update")] 
        public List<sinhvien> Suasinhvien(sinhvien new_sv)
        {
            try
            {
                sinhvien old_sv = db.sinhvien.SingleOrDefault(sv => sv.masv == new_sv.masv);
                old_sv.hoten = new_sv.hoten;
                old_sv.diachi = new_sv.diachi;
                old_sv.dienthoai = new_sv.dienthoai;
                old_sv.malop = new_sv.malop;
                old_sv.anh = new_sv.anh;
				db.SaveChanges();
				return db.sinhvien.ToList();
			}
            catch
            {
                return null;
            }
        }

		// 4. [HttpDelete]: dùng để xóa dữ liệu
		[HttpDelete]
		[Route("api/th/delete")]
		public List<sinhvien> Xoasinhvien(int masv)
		{
			try
			{
				sinhvien sv = db.sinhvien.SingleOrDefault(s => s.masv == masv);
                if (sv != null)
                {
				    db.sinhvien.Remove(sv);
				    db.SaveChanges();
				    return db.sinhvien.ToList();
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
