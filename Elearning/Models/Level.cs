using System;
using System.Collections.Generic;

#nullable disable

namespace ELearning.Models
{
    public partial class Level
    {
        public Level()
        {
            Modules = new HashSet<Module>();
        }

        public int Id { get; set; }
        public string Level1 { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Module> Modules { get; set; }
    }
}
