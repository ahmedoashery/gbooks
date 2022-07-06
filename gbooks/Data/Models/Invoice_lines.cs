namespace gbooks.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gbooks.invoice_lines")]
    public partial class invoice_lines
    {
        public int id { get; set; }

        public int invoice_id { get; set; }

        public int? account_id { get; set; }

        public int item_id { get; set; }

        public int quantity { get; set; }

        public int price { get; set; }

        public virtual Account account { get; set; }

        public virtual invoice invoice { get; set; }

        public virtual item item { get; set; }
    }
}
