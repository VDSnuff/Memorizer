using System;
using System.ComponentModel.DataAnnotations;

namespace Memorizer.Models
{
    public class StudyingEntityWord
    {
        [Key]
        public int Id { get; set; }
        public string UserNote { get; set; }
        public Word Word { get; set; }
        public StudyingProcesInfo StudyingProcesInfo { get; set; }

        public StudyingEntityWord(Word word, StudyingProcesInfo studyingProcesInfo, string userNote = null)
        {
            Word = word;
            StudyingProcesInfo = studyingProcesInfo;
            UserNote = userNote;
        }
    }
}
