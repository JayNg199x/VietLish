using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietLish.DTO
{
    public class VocabInModuleDTO
    {
        public VocabInModuleDTO(int id, string module1, int partId, int levelId, string image, bool status)
        {
            Id = id;
            Module1 = module1;
            PartId = partId;
            LevelId = levelId;
            Image = image;
            Status = status;
        }

        public int Id { get; set; }
        public string Module1 { get; set; }
        public int PartId { get; set; }
        public int LevelId { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}

