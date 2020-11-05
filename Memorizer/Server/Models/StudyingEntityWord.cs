using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Memorizer.Server.Models
{
    public class StudyingEntityWord : StudyingEntity
    {
        //public int Id { get; set; }
        //public StudyingDataType StudyingDataType { get; set; }
        //public StudyingProcesInfo StudyingProcesInfo { get; set; }
        //public string UserNote { get; set; }
        //public List<Tag> Tags { get; set; }
        public Word Word { get; set; }
        public List<StudyingEntityWordTag> StudyingEntityWordTags { get; set; }
        //public string ApplicationUserId { get; set; }
        //[JsonIgnore]
        //public ApplicationUser ApplicationUser { get; set; }
    }
}
