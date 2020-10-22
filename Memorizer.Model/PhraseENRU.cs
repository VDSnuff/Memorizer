using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Memorize.Server.Models
{
    public class PhraseENRU
    {
        [Key]
        public string Id { get; set; }
        public string Value { get; set; }
        public string Translation { get; set; }
        public string Definition { get; set; }
    }
}
