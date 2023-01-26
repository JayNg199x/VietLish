namespace VietLish.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Test")]
    public partial class Test
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Test()
        {
            Questions = new HashSet<Question>();
            QuestionOfTests = new HashSet<QuestionOfTest>();
            ScoreOfTests = new HashSet<ScoreOfTest>();
            Sentences = new HashSet<Sentence>();
            Vocabularies = new HashSet<Vocabulary>();
        }

        [Key]
        public int test_id { get; set; }

        [StringLength(200)]
        public string description { get; set; }

        public DateTime? date_created { get; set; }

        public TimeSpan test_time { get; set; }

        public int num_p1 { get; set; }

        public int num_p2 { get; set; }

        public int num_p3 { get; set; }

        public int num_p4 { get; set; }

        public int num_p5 { get; set; }

        public int num_p6 { get; set; }

        public int num_p7 { get; set; }

        public int total_tester { get; set; }

        public string level_of_test { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionOfTest> QuestionOfTests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScoreOfTest> ScoreOfTests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sentence> Sentences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vocabulary> Vocabularies { get; set; }
    }
}
