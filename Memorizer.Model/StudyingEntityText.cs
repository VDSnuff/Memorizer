using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Memorizer.Models
{
    public class StudyingEntityText
    {
        [Key]
        public int Id { get; set; }
        public StudyingDataType StudyingDataType  { get; set; }
        public Text Text { get; set; }
        public StudyingProcesInfo StudyingProcesInfo { get; set; }
        public string UserNote { get; set; }
        List<Tag> Tags { get; set; }
        public StudyingEntityText(StudyingDataType studyingDataType, Text text, List<Tag> tags, string userNote = null)
        {
            StudyingDataType = studyingDataType;
            Text = text;
            UserNote = userNote;
            Tags = new List<Tag>(tags);
            StudyingProcesInfo = new StudyingProcesInfo();
        }

    }
}
