using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bai9_2.Models
{
	public partial class QlbanHang : DbContext
	{
		public QlbanHang()
			: base("name=QlbanHang")
		{
		}

		public virtual DbSet<DanhMuc> DanhMuc { get; set; }
		public virtual DbSet<SanPham> SanPham { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
