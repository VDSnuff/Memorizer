using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Memorize.Server.Models
{
    public class WordENRU
    {
        [Key]
        public string Id { get; set; }
        public string Value { get; set; }
        public List<string> Synonyms { get; set; }
        public string Translation { get; set; }
        public string Definition { get; set; }
        public string AssociatedImage { get; set; }
    }
}
