using System.ComponentModel.DataAnnotations;

namespace Memorizer.Models
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
        public string Language { get; set; }
        public string TranslationLanguage { get; set; }

        public Word(string value, string synonyms, string translation, 
                    string definition, string associatedImage, 
                    string language, string translationLanguage)
        {
            Value = value;
            Synonyms = synonyms;
            Translation = translation;
            Definition = definition;
            AssociatedImage = associatedImage;
            Language = language;
            TranslationLanguage = translationLanguage;
        }
    }
}
