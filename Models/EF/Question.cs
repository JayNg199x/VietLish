namespace VietLish.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Question")]
    public partial class Question
    {
        [Key]
        public int question_id { get; set; }

        [Column("question")]
        public string question1 { get; set; }

        public string A { get; set; }

        public string B { get; set; }

        public string C { get; set; }

        public string D { get; set; }

        [Required]
        [StringLength(5)]
        public string answer { get; set; }

        public int? module_id { get; set; }

        public virtual Module Module { get; set; }
    }
}
