using Memorizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memorizer.Server.Data
{
    public interface IStudyingEntityWordRepository
    {
        IEnumerable<StudyingEntityWord> GetAll();
        StudyingEntityWord GetById(string id);
        StudyingEntityWord Update(StudyingEntityWord studyingEntityWord);
        StudyingEntityWord Add(StudyingEntityWord studyingEntityWord);
        StudyingEntityWord Delete(string id);
        bool Commit();
    }
}
