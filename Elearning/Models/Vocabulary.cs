using System;
using System.Collections.Generic;

#nullable disable

namespace ELearning.Models
{
    public partial class Vocabulary
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public string Image { get; set; }
        public string Word { get; set; }
        public string Pronunciation { get; set; }
        public string Means { get; set; }



        public virtual Module Module { get; set; }
    }
}
