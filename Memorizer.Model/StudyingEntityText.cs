using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Memorizer.Models
{
    public class StudyingEntityText : StudyingEntity
    {
        //[Key]
        //public int Id { get; set; }
        //public StudyingDataType StudyingDataType { get; set; }
        //public StudyingProcesInfo StudyingProcesInfo { get; set; }
        //public string UserNote { get; set; }
        //public List<Tag> Tags { get; set; }
        public Text Text { get; set; }


        //public StudyingEntityText(StudyingDataType studyingDataType, List<Tag> tags, string userNote, Text text)
        //{
        //    StudyingDataType = studyingDataType;
        //    Text = text;
        //    UserNote = userNote;
        //    Tags = new List<Tag>(tags);
        //    StudyingProcesInfo = new StudyingProcesInfo();
        //}
    }
}
