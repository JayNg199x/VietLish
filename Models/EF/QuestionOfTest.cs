namespace VietLish.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuestionOfTest")]
    public partial class QuestionOfTest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int question_of_test_id { get; set; }

        public int question_id { get; set; }

        public int test_id { get; set; }

        public int? number_of_ques { get; set; }

        public DateTime? test_day { get; set; }

        public virtual Question Question { get; set; }

        public virtual Test Test { get; set; }
    }
}
