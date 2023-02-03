namespace VietLish.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sentence")]
    public partial class Sentence
    {
        [Key]
        public int sentence_id { get; set; }

        [Column("sentence")]
        [Required]
        public string sentence1 { get; set; }

        [Required]
        public string means { get; set; }

        public string image { get; set; }

        public int? module_id { get; set; }

        public virtual Module Module { get; set; }
    }
}
