namespace gbooks.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gbooks.invoices")]
    public partial class invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public invoice()
        {
            invoice_lines = new HashSet<invoice_lines>();
            invoice_payments = new HashSet<invoice_payments>();
        }

        public int id { get; set; }

        public int? number { get; set; }

        public int ar_account_id { get; set; }

        public int customer_id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime due_date { get; set; }

        [Required]
        [StringLength(2048)]
        public string reference { get; set; }

        [Required]
        [StringLength(2048)]
        public string memo { get; set; }

        public bool is_paid { get; set; }

        public DateTime? paid_date { get; set; }

        public bool? is_active { get; set; }

        public virtual Account account { get; set; }

        public virtual customer customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<invoice_lines> invoice_lines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<invoice_payments> invoice_payments { get; set; }
    }
}
