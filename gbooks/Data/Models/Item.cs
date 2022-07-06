namespace gbooks.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gbooks.items")]
    public partial class item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public item()
        {
            bill_lines = new HashSet<bill_lines>();
            invoice_lines = new HashSet<invoice_lines>();
        }

        public int id { get; set; }

        public int? type_id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? creation_date { get; set; }

        public int? income_account_id { get; set; }

        public int? cogs_account_id { get; set; }

        public int? asset_account_id { get; set; }

        public int? vendor_id { get; set; }

        public int? qty_on_hand { get; set; }

        public decimal? cost { get; set; }

        public decimal? price { get; set; }

        public bool? is_active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bill_lines> bill_lines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<invoice_lines> invoice_lines { get; set; }

        public virtual type type { get; set; }
    }
}
