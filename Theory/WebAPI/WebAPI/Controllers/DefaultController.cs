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
		// phương thức get
		[HttpGet]
		public string sayHello(string name)
		{
			return "Hello world " + name;
		}

		[HttpGet]
		[Route("api/tong")] // dùng Route bí danh để đỡ phải sửa link dài khi khởi chạy
		public string tong(int a, int b)
		{
			return $"{a} + {b} = {a + b}";
		}

		// phương thức post (chạy thử trong postman)
		[HttpPost]
		public int dientich(int a, int b)
		{
			return a * b;
		}



		List<SinhVien> ds;
		public DefaultController()
		{
			ds = new List<SinhVien>();
			ds.Add(new SinhVien("sv01", "quang", 20, "Hà Nội"));
			ds.Add(new SinhVien("sv02", "hùng", 21, "Thái Bình"));
			ds.Add(new SinhVien("sv03", "hải", 22, "Quảng Ninh"));
			ds.Add(new SinhVien("sv04", "thái", 23, "Hải Dương"));
			ds.Add(new SinhVien("sv05", "vương", 24, "Hải Dương"));
		}

		[HttpGet]
		[Route("api/ds")]
		public List<SinhVien> danhsach()
		{
			return ds;
		}

		[HttpGet]
		[Route("api/ds_hanoi1")]
		public List<SinhVien> danhsach_HaNoi1()
		{
			List <SinhVien> lst = new List<SinhVien>();
			foreach(SinhVien s in ds)
			{
				if (s.diachi.Equals("Hà Nội"))
					lst.Add(s);
			}
			return lst;
		}

		[HttpGet]
		[Route("api/ds_hanoi2")]
		public List<SinhVien> danhsach_HaNoi2()
		{
			return ds.Where(s => s.diachi == "HaNoi").ToList();
		}

		[HttpDelete]
		[Route("api/xoa")]
		public bool XoaSV(string masv)
		{
			try
			{
				SinhVien s = new SinhVien();
				s.masv = masv;
				if (ds.Contains(s))
				{
					ds.Remove(s);
					return true;
				}
				else
					return false;
			}
			catch
			{
				return false;
			}
		}
	}
}
