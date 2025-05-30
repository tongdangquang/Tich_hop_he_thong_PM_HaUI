using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Call_API_winform
{
	[DataContract]
	public class DonVi
	{
		[DataMember]
		public int MaDonVi { get; set; }
		[DataMember]
		public string TenDonVi { get; set; }

		public DonVi(int MaDonVi, string TenDonVi)
		{
			this.MaDonVi = MaDonVi;
			this.TenDonVi = TenDonVi;
		}
	}
}
