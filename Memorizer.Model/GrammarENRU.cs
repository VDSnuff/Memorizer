using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Memorize.Server.Models
{
    public class GrammarENRU
    {
        [Key]
        public string Id { get; set; }
        public string Value { get; set; }
        public string Translate { get; set; }
        public string PhraseDefinition { get; set; }
        public int RepetitionCount  { get; set; }
        public int Rank { get; set; }
        public bool Trained { get; set; } = false;
        public DateTime CreationDate { get; set; }
        public DateTime LastRepetitionDate { get; set; }
    }
}
