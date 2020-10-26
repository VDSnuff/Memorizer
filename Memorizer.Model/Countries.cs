using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Memorizer.Models
{
   public class Countries
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
