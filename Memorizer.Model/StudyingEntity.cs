using System;
using System.Collections.Generic;
using System.Text;

namespace Memorizer.Models
{
    public abstract class StudyingEntity
    {
        public int Id { get; set; }
        public StudyingDataType StudyingDataType { get; set; }
        public StudyingProcesInfo StudyingProcesInfo { get; set; }
        public string UserNote { get; set; }
        public List<Tag> Tags { get; set; }

        public StudyingEntity()
        {

        }

        public StudyingEntity(StudyingDataType studyingDataType, List<Tag> tags, string userNote)
        {
            StudyingDataType = studyingDataType;
            UserNote = userNote;
            Tags = new List<Tag>(tags);
            StudyingProcesInfo = new StudyingProcesInfo();
        }
    }
}
