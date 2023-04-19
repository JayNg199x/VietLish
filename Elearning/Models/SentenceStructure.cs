using System;
using System.Collections.Generic;

#nullable disable

namespace ELearning.Models
{
    public partial class SentenceStructure
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public int ModuleId { get; set; }
        public string Sentence { get; set; }
        public virtual Module Module { get; set; }
    }
}
