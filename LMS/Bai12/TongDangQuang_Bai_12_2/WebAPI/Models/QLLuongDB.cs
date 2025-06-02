using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebAPI.Models
{
	public partial class QLLuongDB : DbContext
	{
		public QLLuongDB()
			: base("name=QLLuongDB")
		{
		}

		public virtual DbSet<DonVi> DonVi { get; set; }
		public virtual DbSet<NhanVien> NhanVien { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
