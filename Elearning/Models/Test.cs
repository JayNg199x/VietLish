using System;
using System.Collections.Generic;

#nullable disable

namespace ELearning.Models
{
    public partial class Test
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public string Question { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }

        public string Correct{ get; set; }

        public virtual Module Module { get; set; }
    }
}
