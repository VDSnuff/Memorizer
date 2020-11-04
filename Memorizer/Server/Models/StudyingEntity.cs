using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Memorizer.Server.Models
{
    public abstract class StudyingEntity
    {
        public int Id { get; set; }
        public StudyingDataType StudyingDataType { get; set; }
        public StudyingProcesInfo StudyingProcesInfo { get; set; }
        public string UserNote { get; set; }
        public List<Tag> Tags { get; set; }

        public string ApplicationUserId { get; set; }
        [JsonIgnore]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
