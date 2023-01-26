namespace VietLish.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vocabulary")]
    public partial class Vocabulary
    {
        [Key]
        public int vocab_id { get; set; }

        [Required]
        [StringLength(50)]
        public string vocab_name { get; set; }

        [Required]
        [StringLength(100)]
        public string spelling { get; set; }

        [StringLength(100)]
        public string vocab_type { get; set; }

        [Required]
        [StringLength(100)]
        public string means { get; set; }

        [StringLength(100)]
        public string synonym { get; set; }

        [StringLength(100)]
        public string antonym { get; set; }

        public string image { get; set; }

        public int? module_id { get; set; }

        public int? test_id { get; set; }

        public virtual Module Module { get; set; }

        public virtual Test Test { get; set; }
    }
}
