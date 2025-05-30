namespace WEP_API_DATABASE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sinhvien")]
    public partial class sinhvien
    {
        [Key]
        public int masv { get; set; }

        [StringLength(30)]
        public string hoten { get; set; }

        [StringLength(30)]
        public string diachi { get; set; }

        [StringLength(12)]
        public string dienthoai { get; set; }

        public int? malop { get; set; }

        [StringLength(255)]
        public string anh { get; set; }

        public virtual lophoc lophoc { get; set; }
    }
}
