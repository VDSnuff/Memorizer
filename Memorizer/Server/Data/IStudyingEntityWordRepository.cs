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
        StudyingEntityWord GetById(int id);
        StudyingEntityWord Update(StudyingEntityWord studyingEntityWord);
        StudyingEntityWord Add(StudyingEntityWord studyingEntityWord);
        StudyingEntityWord Delete(int id);
        bool Commit();
    }
}
