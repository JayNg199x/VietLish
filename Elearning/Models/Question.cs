﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ELearning.Models
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
        }
        public Question(int moduleId, string question1)
        {
            ModuleId = moduleId;
            Question1 = question1;
        }


        public int Id { get; set; }
        public int ModuleId { get; set; }
        public string Question1 { get; set; }

        public virtual Module Module { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }


    }
}
