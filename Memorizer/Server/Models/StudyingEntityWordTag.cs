using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memorizer.Server.Models
{
    public class StudyingEntityWordTag
    {
        public int Id { get; set; }
        public int StudyingEntityWordId { get; set; }
        public StudyingEntityWord StudyingEntityWord { get; set; }

        public string TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
