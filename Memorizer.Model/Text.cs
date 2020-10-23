using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Memorizer.Models
{
   public class Text
    {
        [Key]
        public string Id { get; set; }
        public string Topic { get; set; }
        public string Value { get; set; }
        public string Language { get; set; }
    }
}
