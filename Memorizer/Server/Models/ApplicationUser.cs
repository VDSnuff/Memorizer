using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Memorizer.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<StudyingEntityText> StudyingEntityTexts { set; get; }
        public ICollection<StudyingEntityWord> StudyingEntityWords { set; get; }
    }
}
