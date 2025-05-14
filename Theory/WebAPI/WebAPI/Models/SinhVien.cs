using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
	public class SinhVien
	{
		public string masv { get; set; }
		public string hoten { get; set; }
		public int tuoi { get; set; }
		public string diachi { get; set; }

		public SinhVien()
		{

		}

		public SinhVien(string masv, string hoten, int tuoi, string diachi)
		{
			this.masv = masv;
			this.hoten = hoten;
			this.tuoi = tuoi;
			this.diachi = diachi;
		}

		public override bool Equals(object obj)
		{
			return obj is SinhVien vien &&
				   masv == vien.masv;
		}
	}
}