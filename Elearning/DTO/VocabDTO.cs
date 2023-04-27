using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietLish.DTO
{
    public class VocabDTO
    {
        public int Id { get; set; }
        public string Module { get; set; }
        public string Image { get; set; }
        public string Word { get; set; }
        public string Pronunciation { get; set; }
        public string Meaning { get; set; }
       

        public VocabDTO(int id, string module, string image, string word, string pronunciation, string meaning)
        {
            Id = id;
            Module = module;
            Image = image;
            Word = word;
            Pronunciation = pronunciation;
            Meaning = meaning;
           
        }
    }
}

