using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Memorizer.Server.Models
{
    public class StudyingEntityText : StudyingEntity
    {
        //public int Id { get; set; }
        //public StudyingDataType StudyingDataType { get; set; }
        //public StudyingProcesInfo StudyingProcesInfo { get; set; }
        //public string UserNote { get; set; }
        //public List<Tag> Tags { get; set; }
        public Text Text { get; set; }
        public List<StudyingEntityTextTag> StudyingEntityTextTags { get; set; }

        //public string ApplicationUserId { get; set; }
        //[JsonIgnore]
        //public ApplicationUser ApplicationUser { get; set; }
    }
}
