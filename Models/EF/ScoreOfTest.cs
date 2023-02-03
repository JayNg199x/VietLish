namespace VietLish.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ScoreOfTest")]
    public partial class ScoreOfTest
    {
        [Key]
        public int score_test_id { get; set; }

        public int listening_score { get; set; }

        public int total_score { get; set; }

        public int test_id { get; set; }

        [StringLength(30)]
        public string account_id { get; set; }

        public DateTime? date_of_test { get; set; }

        public virtual Account Account { get; set; }

        public virtual Test Test { get; set; }
    }
}
