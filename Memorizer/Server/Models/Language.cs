using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Memorizer.Server.Models
{
   public class Language
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }

    }
}
