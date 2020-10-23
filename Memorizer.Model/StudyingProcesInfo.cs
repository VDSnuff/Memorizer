using Memorizer.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Memorizer.Models
{
    public class StudyingProcesInfo
    {
        [Key]
        public string Id { get; set; }
        public int RepetitionCount { get; set; }
        public LearningStatus LearningStatus { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastRepetition { get; set; }
        public DateTime NextRepetition { get; set; }
    }
}
