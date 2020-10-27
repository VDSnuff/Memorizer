using System;
using System.ComponentModel.DataAnnotations;

namespace Memorizer.Server.Models
{
    public class StudyingProcesInfo
    {
        [Key]
        public int Id { get; set; }
        public int RepetitionCount { get; set; }
        public LearningStatus LearningStatus { get; set; }
        public DateTime CreationDate { get; set ; }
        public DateTime? LastRepetition { get; set; }
        public DateTime NextRepetition { get; set; }

        public StudyingProcesInfo()
        {
            RepetitionCount = 0;
            LearningStatus = LearningStatus.New;
            CreationDate = DateTime.UtcNow;
            LastRepetition = DateTime.UtcNow;
            NextRepetition = DateTime.UtcNow.AddDays(1);
            // TO DO => NextRepetition = BL.CalculateNextRepetition();
        }
    }
}
