using System;
using System.Collections.Generic;

#nullable disable

namespace ELearning.Models
{
    public partial class Sentence
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public int ModuleId { get; set; }

        public virtual Module ModuleInSentence { get; set; }
    }
}
