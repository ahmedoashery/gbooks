namespace gbooks.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gbooks.invoice_payments")]
    public partial class invoice_payments
    {
        public int id { get; set; }

        public int invoice_id { get; set; }

        public int transcation_id { get; set; }

        [Required]
        [StringLength(2048)]
        public string memo { get; set; }

        [Required]
        [StringLength(2048)]
        public string reference { get; set; }

        public DateTime creation_date { get; set; }

        public bool is_active { get; set; }

        public virtual invoice invoice { get; set; }
    }
}
