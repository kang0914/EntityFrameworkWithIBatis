namespace EntityWithIBatis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MM_CODE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string GROUP_CODE { get; set; }

        [StringLength(50)]
        public string GROUP_NAME { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string DATA1 { get; set; }

        [StringLength(50)]
        public string DATA2 { get; set; }

        [StringLength(50)]
        public string DATA3 { get; set; }

        [StringLength(50)]
        public string IUSER { get; set; }

        public DateTime? IDATE { get; set; }

        [StringLength(50)]
        public string DUSER { get; set; }

        public DateTime? DDATE { get; set; }
    }
}
