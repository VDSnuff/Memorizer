using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Memorize.Server.Models
{
    public class Study
    {
        [Key]
        public string Id { get; set; }
        public string Topic { get; set; } = "default";
        public string StudyingSubjectId { get; set; }
        public int RepetitionCount { get; set; }
        public LearningStatus LStatus { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastRepetition { get; set; }
        public DateTime NextRepetition { get; set; }
        public string UserNote { get; set; }
        public enum LearningStatus : int
        {
            New = 0,
            InProgress = 1,
            Done = 2
        }
    }
}
