using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Memorizer.Models
{
    public class Text
    {
        [Key]
        public int Id { get; set; }
        public string Topic { get; set; }
        public string Value { get; set; }
        public string Language { get; set; }

        //public Text(string topic, string value, string language)
        //{
        //    Topic = topic;
        //    Value = value;
        //    Language = language;
        //}
    }
}
