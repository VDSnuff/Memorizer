using Memorizer.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memorizer.Server.Data
{
    public interface IStudyingEntityTextRepository
    {
        IEnumerable<StudyingEntityText> GetAll();
        StudyingEntityText GetById(int id);
        StudyingEntityText Update(StudyingEntityText studyingEntityText);
        StudyingEntityText Add(StudyingEntityText studyingEntityText);
        StudyingEntityText Delete(int id);
        bool Commit();
    }
}
