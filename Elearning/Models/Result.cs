using System;
using System.Collections.Generic;

#nullable disable

namespace ELearning.Models
{
    public partial class Result
    {
        
        public int Id { get; set; }
        public int? AccountId { get; set; }
        public int? ModuleId { get; set; }
        public bool? Status { get; set; }

        public virtual Account Account { get; set; }
        public virtual Module Module { get; set; }

    }
}
