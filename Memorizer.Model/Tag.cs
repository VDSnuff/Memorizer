using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Memorizer.Models
{
    public class Tag
    {
        [Key]
        public string Name { get; set; }
    }
}
