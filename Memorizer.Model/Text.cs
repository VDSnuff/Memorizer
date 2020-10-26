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
        public Language Language { get; set; }
    }
}
