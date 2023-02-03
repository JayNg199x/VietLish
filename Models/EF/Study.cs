namespace VietLish.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Study
    {
        [Key]
        public int studies_id { get; set; }

        [Required]
        public string status_study { get; set; }

        public int? module_id { get; set; }

        [StringLength(30)]
        public string account_id { get; set; }

        public virtual Account Account { get; set; }

        public virtual Module Module { get; set; }
    }
}
