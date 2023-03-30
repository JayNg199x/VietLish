using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ELearning.Models;

namespace VietLish.DTO
{
    public class ResultDTO
    {
        public ResultDTO(string module, string level, bool? status)
        {
            Module = module;
            Level = level;
            Status = status;
        }

        public string Module { get; set; }
        public string Level { get; set; }
        public bool? Status { get; set; }

    }
}