using Memorizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memorizer.Server.Data
{
    public interface IStudyingEntityTextRepository
    {
        IEnumerable<StudyingEntityText> GetAll();
        StudyingEntityText GetById(string id);
        StudyingEntityText Update(StudyingEntityText studyingEntityText);
        StudyingEntityText Add(StudyingEntityText studyingEntityText);
        StudyingEntityText Delete(string id);
        bool Commit();
    }
}
