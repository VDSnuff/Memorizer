using Memorizer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Memorizer.Models
{
    public class StudyingEntityText
    {
        [Key]
        public string Id { get; set; }
        public string UserNote { get; set; } = String.Empty;
        public StudyingDataType StudyingDataType  { get; set; }
        public Text Text { get; set; }
        public StudyingProcesInfo StudyingProcesInfo { get; set; }

    }
}
