using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Memorizer.Models
{
    public class StudyingEntityWord : StudyingEntity
    {
        //[Key]
        //public int Id { get; set; }
        //public string UserNote { get; set; }
        //public StudyingProcesInfo StudyingProcesInfo { get; set; }
        //public List<Tag> Tags { get; set; }
        public Word Word { get; set; }
        //public StudyingEntityWord(StudyingDataType studyingDataType,  List<Tag> tags, string userNote, Word word) : base(studyingDataType, tags, userNote)
        //{
        //    Word = word;
        //    //StudyingProcesInfo = studyingProcesInfo;
        //    //UserNote = userNote;
        //    //Tags = new List<Tag>(tags);
        //}
    }
}
