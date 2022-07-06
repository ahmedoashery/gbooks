namespace gbooks.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gbooks.splits")]
    public partial class split
    {
        public int id { get; set; }

        public int? transaction_id { get; set; }

        public int? account_id { get; set; }

        public int? entity_id { get; set; }

        public int? amount { get; set; }

        [StringLength(255)]
        public string memo { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }

        public virtual Account account { get; set; }

        public virtual transaction transaction { get; set; }
    }
}
