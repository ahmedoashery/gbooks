namespace gbooks.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gbooks.vendors")]
    public partial class vendor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vendor()
        {
            bills = new HashSet<Bill>();
        }

        public int id { get; set; }

        public int? type_id { get; set; }

        [StringLength(255)]
        public string account_number { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [StringLength(255)]
        public string phone1 { get; set; }

        [StringLength(255)]
        public string phone2 { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string fax { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [StringLength(255)]
        public string city { get; set; }

        [StringLength(255)]
        public string country { get; set; }

        [StringLength(255)]
        public string company { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? created_at { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [StringLength(255)]
        public string postal_code { get; set; }

        public decimal? balance { get; set; }

        public decimal? open_balance { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? open_balance_date { get; set; }

        public DateTime? start_date { get; set; }

        public DateTime? end_date { get; set; }

        [StringLength(255)]
        public string notes { get; set; }

        public bool is_active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> bills { get; set; }

        public virtual type type { get; set; }
    }
}
