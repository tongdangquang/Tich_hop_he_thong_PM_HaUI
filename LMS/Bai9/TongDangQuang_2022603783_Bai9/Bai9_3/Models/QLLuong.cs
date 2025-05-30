using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bai9_3.Models
{
	public partial class QLLuong : DbContext
	{
		public QLLuong()
			: base("name=QLLuong")
		{
		}

		public virtual DbSet<DonVi> DonVi { get; set; }
		public virtual DbSet<NhanVien> NhanVien { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
