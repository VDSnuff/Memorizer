using System.ComponentModel.DataAnnotations;

namespace Memorizer.Server.Models
{
    public class Word
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }
        public string Synonyms { get; set; }
        public string Translation { get; set; }
        public string Definition { get; set; }
        public string AssociatedImage { get; set; }
        public Language Language { get; set; }
        public Language TranslationLanguage { get; set; }
    }
}
