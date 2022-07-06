namespace gbooks.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gbooks.employees")]
    public partial class employee
    {
        public int id { get; set; }

        public int job_id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        public DateTime creation_date { get; set; }

        public bool is_active { get; set; }

        public virtual job job { get; set; }
    }
}
