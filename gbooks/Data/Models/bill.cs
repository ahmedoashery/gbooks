namespace gbooks.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gbooks.bills")]
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            bill_lines = new HashSet<bill_lines>();
            bill_payments = new HashSet<bill_payments>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string number { get; set; }

        public int ap_account_id { get; set; }

        public int vendor_id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime due_date { get; set; }

        [StringLength(255)]
        public string reference { get; set; }

        [StringLength(255)]
        public string memo { get; set; }

        public bool is_paid { get; set; }

        public DateTime? paid_date { get; set; }

        public int? amount_due { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? created_at { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        public bool? is_active { get; set; }

        public virtual Account account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bill_lines> bill_lines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bill_payments> bill_payments { get; set; }

        public virtual vendor vendor { get; set; }
    }
}
