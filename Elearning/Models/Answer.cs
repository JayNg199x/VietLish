using System;
using System.Collections.Generic;

#nullable disable

namespace ELearning.Models
{
    public partial class Answer
    {
        public Answer(int questionId, string answer1, bool? correct)
        {
            QuestionId = questionId;
            Answer1 = answer1;
            Correct = correct;
        }

        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Answer1 { get; set; }
        public bool? Correct { get; set; }

        public virtual Question Question { get; set; }

    }
}
