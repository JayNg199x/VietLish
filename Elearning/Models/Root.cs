using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace ELearning.Models
{
    public partial class Root
    {
      
        public string issuer { get; set; }
        public string originalIssuer { get; set; }
        public string type { get; set; }
        public string value { get; set; }

    }
}
