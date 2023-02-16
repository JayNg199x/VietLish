﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ELearning.Models
{
    public partial class Module
    {
        public Module()
        {
            Sentences = new HashSet<Sentence>();
            VocabInModule = new HashSet<Vocabulary>();
        }

        public int Id { get; set; }
        public string Module1 { get; set; }
        public string Image { get; set; }
        public int PartId { get; set; }
        public int LevelId { get; set; }

        public virtual Level Level { get; set; }
        public virtual Part Part { get; set; }
        public virtual ICollection<Sentence> Sentences { get; set; }
        public virtual ICollection<Vocabulary> VocabInModule { get; set; }
    }
}