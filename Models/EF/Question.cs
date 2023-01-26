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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            QuestionOfTests = new HashSet<QuestionOfTest>();
        }

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

        public int level_id { get; set; }

        public int? test_id { get; set; }

        public int? part_id { get; set; }

        public virtual Level Level { get; set; }

        public virtual Part Part { get; set; }

        public virtual Test Test { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionOfTest> QuestionOfTests { get; set; }
    }
}
