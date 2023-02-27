using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearning.Models
{
    public class ExampleViewModel
    {
        public ExampleViewModel()
        {
            Answers = new Dictionary<string, string>();
            Questions = new List<KeyValuePair<string, List<string>>>();

        }
        public Dictionary <string, string> Answers { get; set; }
        public List<KeyValuePair<string, List<string>>> Questions { get; set; }

        public ExampleViewModel Add(int id, string key, string[] value)
        {
            Questions.Add(new KeyValuePair<string, List<string> > (key, value.ToList()));
            return this;
        }
      
    }
}
