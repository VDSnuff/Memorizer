using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Memorizer.Models
{
    public class Word
    {
        [Key]
        public string Id { get; set; }
        public string Value { get; set; }
        public string Synonyms { get; set; }
        public string Translation { get; set; }
        public string Definition { get; set; }
        public string AssociatedImage { get; set; }
        public string Language { get; set; }
        public string TranslationLanguage { get; set; }
    }
}
