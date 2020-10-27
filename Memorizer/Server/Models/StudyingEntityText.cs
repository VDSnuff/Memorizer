using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Memorizer.Server.Models
{
    public class StudyingEntityText
    {
        public int Id { get; set; }
        public StudyingDataType StudyingDataType { get; set; }
        public StudyingProcesInfo StudyingProcesInfo { get; set; }
        public string UserNote { get; set; }
        public List<Tag> Tags { get; set; }
        public Text Text { get; set; }
    }
}
