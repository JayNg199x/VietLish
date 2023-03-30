using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietLish.DTO
{
    public class ModuleDTO
    {
        public ModuleDTO(int id, string module1, string part, string level, string image, bool? status)
        {
            Id = id;
            Module1 = module1;
            Part = part;
            Level = level;
            Image = image;
            Status = status;
        }
        public ModuleDTO(int id, string module1, string part, string level, string image)
        {
            Id = id;
            Module1 = module1;
            Part = part;
            Level = level;
            Image = image;
        }

        public int Id { get; set; }
        public string Module1 { get; set; }
        public string Part { get; set; }
        public string Level { get; set; }
        public string Image { get; set; }
        public bool? Status { get; set; }



    }
}
