namespace gbooks.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gbooks.accounts")]
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            accounts1 = new HashSet<Account>();
            bill_lines = new HashSet<bill_lines>();
            bills = new HashSet<Bill>();
            invoices = new HashSet<invoice>();
            invoice_lines = new HashSet<invoice_lines>();
            splits = new HashSet<split>();
        }

        public int id { get; set; }

        public int? type_id { get; set; }

        public int? parent_id { get; set; }

        public int? number { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        public decimal? open_balance { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? open_balance_date { get; set; }

        public decimal? total_balance { get; set; }

        public bool? is_active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> accounts1 { get; set; }

        public virtual Account account1 { get; set; }

        public virtual type type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bill_lines> bill_lines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> bills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<invoice> invoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<invoice_lines> invoice_lines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<split> splits { get; set; }
    }
}
