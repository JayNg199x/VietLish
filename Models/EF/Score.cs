namespace VietLish.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Score")]
    public partial class Score
    {
        [Key]
        public int score_id { get; set; }

        public int? listening_score { get; set; }

        public int? reading_score { get; set; }

        public int? total_score { get; set; }

        [StringLength(30)]
        public string account_id { get; set; }

        public virtual Account Account { get; set; }
    }
}
