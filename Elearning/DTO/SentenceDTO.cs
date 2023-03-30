using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ELearning.Models;

namespace VietLish.DTO
{
    public class SentenceDTO
    {
        public int Id { get; set; }
        public string Module { get; set; }
        public int ModuleId { get; set; }
        public string Sentence { get; set; }

        public SentenceDTO(int id, string module, string sentence)
        {
            Id = id;
            Module = module;
            Sentence = sentence;
        }

        public SentenceDTO(int id, string module, int moduleId, string sentence)
        {
            Id = id;
            Module = module;
            ModuleId = moduleId;
            Sentence = sentence;
        }
    }
}