namespace gbooks.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gbooks.bill_lines")]
    public partial class bill_lines
    {
        public int id { get; set; }

        public DateTime? date { get; set; }

        public int bill_id { get; set; }

        public int item_id { get; set; }

        public int? account_id { get; set; }

        public int quantity { get; set; }

        public int cost { get; set; }

        [StringLength(500)]
        public string memo { get; set; }

        public virtual Account account { get; set; }

        public virtual Bill bill { get; set; }

        public virtual item item { get; set; }
    }
}
