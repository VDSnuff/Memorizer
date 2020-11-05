using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memorizer.Server.Models
{
    public class StudyingEntityTextTag
    {
        public int Id { get; set; }
        public int StudyingEntityTextId { get; set; }
        public StudyingEntityText StudyingEntityText { get; set; }

        public string TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
