using System;
using System.Collections.Generic;

#nullable disable

namespace ELearning.Models
{
    public partial class Module
    {
        public Module()
        {
            Questions = new HashSet<Question>();
            Sentences = new HashSet<Sentence>();
            VocabInModule = new HashSet<Vocabulary>();
            Tests = new HashSet<Test>();
        }

        public int Id { get; set; }
        public string Module1 { get; set; }
        public string Image { get; set; }
        public int PartId { get; set; }
        public int LevelId { get; set; }

        public virtual Level Level { get; set; }
        public virtual Part Part { get; set; }

        public virtual ICollection<Question> Questions { get; set; }

        public virtual ICollection<Sentence> Sentences { get; set; }
        public virtual ICollection<Vocabulary> VocabInModule { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
    }
}
