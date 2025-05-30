using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Call_API_winform
{
	[DataContract]
	public class NhanVien
	{
		[DataMember]
		public int Ma { get; set; }
		[DataMember]
		public string HoTen { get; set; }
		[DataMember]
		public string NgaySinh { get; set; }
		[DataMember]
		public string GioiTinh { get; set; }
		[DataMember]
		public double? Hsluong { get; set; }
		[DataMember]
		public int? MaDonVi { get; set; }


		public NhanVien(int Ma, string HoTen, string NgaySinh, string GioiTinh, double Hsluong, int MaDonVi)
		{
			this.Ma = Ma;
			this.HoTen = HoTen;
			this.NgaySinh = NgaySinh;
			this.GioiTinh = GioiTinh;
			this.Hsluong = Hsluong;
			this.MaDonVi = MaDonVi;
		}

	}
}
