using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebAPI.Models
{
	public partial class QLBanHangDB : DbContext
	{
		public QLBanHangDB()
			: base("name=QLBanHangDB")
		{
		}

		public virtual DbSet<DanhMuc> DanhMuc { get; set; }
		public virtual DbSet<SanPham> SanPham { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
