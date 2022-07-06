namespace gbooks.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gbooks.bill_payments")]
    public partial class bill_payments
    {
        public int id { get; set; }

        public int bill_id { get; set; }

        public int transcation_id { get; set; }

        [Required]
        [StringLength(2048)]
        public string memo { get; set; }

        [Required]
        [StringLength(2048)]
        public string reference { get; set; }

        public decimal amount { get; set; }

        public bool is_active { get; set; }

        public virtual Bill bill { get; set; }
    }
}
