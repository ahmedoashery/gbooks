namespace gbooks.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gbooks.transactions")]
    public partial class transaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public transaction()
        {
            splits = new HashSet<split>();
        }

        public int id { get; set; }

        public int? transaction_id { get; set; }

        [Required]
        [StringLength(200)]
        public string type { get; set; }

        public int? entity_id { get; set; }

        public int? account_id { get; set; }

        public int? amount { get; set; }

        [StringLength(255)]
        public string memo { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }

        public bool? is_active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<split> splits { get; set; }
    }
}
