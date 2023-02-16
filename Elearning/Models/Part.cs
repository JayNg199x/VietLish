using System;
using System.Collections.Generic;

#nullable disable

namespace ELearning.Models
{
    public partial class Part
    {
        public Part()
        {
            ModuleInPart = new HashSet<Module>();
        }

        public int Id { get; set; }
        public string PartName { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Module> ModuleInPart { get; set; }

    }
}
