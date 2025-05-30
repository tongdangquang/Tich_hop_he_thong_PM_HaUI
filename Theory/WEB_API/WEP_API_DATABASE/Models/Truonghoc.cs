using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WEP_API_DATABASE.Models
{
	public partial class Truonghoc : DbContext
	{
		public Truonghoc()
			: base("name=Truonghoc")
		{
		}

		public virtual DbSet<lophoc> lophoc { get; set; }
		public virtual DbSet<sinhvien> sinhvien { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
