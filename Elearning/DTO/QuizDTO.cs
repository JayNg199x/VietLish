using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ELearning.Models;
namespace VietLish.DTO
{
    public class QuizDTO
    {
        public int Id { get; set; }
        public string Module { get; set; }
        public string Question { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }

        public QuizDTO(int id, string module, string question, ICollection<Answer> answers)
        {
            Id = id;
            Module = module;
            Question = question;
            Answers = answers;
        }
    }
}


