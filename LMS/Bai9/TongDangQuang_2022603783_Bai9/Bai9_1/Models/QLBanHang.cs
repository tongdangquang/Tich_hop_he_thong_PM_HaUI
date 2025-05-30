using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bai9_1.Models
{
	public partial class QLBanHang : DbContext
	{
		public QLBanHang()
			: base("name=QLBanHang")
		{
		}

		public virtual DbSet<DanhMuc> DanhMuc { get; set; }
		public virtual DbSet<SanPham> SanPham { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
