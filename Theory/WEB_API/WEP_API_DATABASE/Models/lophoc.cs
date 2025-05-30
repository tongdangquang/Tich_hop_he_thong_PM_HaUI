namespace WEP_API_DATABASE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lophoc")]
    public partial class lophoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lophoc()
        {
            sinhvien = new HashSet<sinhvien>();
        }

        [Key]
        public int malop { get; set; }

        [StringLength(30)]
        public string tenlop { get; set; }

        [StringLength(20)]
        public string giangvien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sinhvien> sinhvien { get; set; }
    }
}
