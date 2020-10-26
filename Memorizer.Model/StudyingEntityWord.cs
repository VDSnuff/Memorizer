using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Memorizer.Models
{
    public class StudyingEntityWord : StudyingEntity
    {
        public Word Word { get; set; }
    }
}
