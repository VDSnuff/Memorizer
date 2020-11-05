using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Memorizer.Server.Models
{
    public class Tag
    {
        [Key]
        public string Name { get; set; }
        public ICollection<StudyingEntityText> StudyingEntityTexts { get; set; }
        public List<StudyingEntityTextTag> StudyingEntityTextTags { get; set; }

        public ICollection<StudyingEntityWord> StudyingEntityWords { get; set; }
        public List<StudyingEntityWordTag> StudyingEntityWordTags { get; set; }
    }
}
