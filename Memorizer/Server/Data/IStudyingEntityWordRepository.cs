using Memorizer.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memorizer.Server.Data
{
    public interface IStudyingEntityWordRepository
    {
        Task<List<StudyingEntityWord>> GetAll();
        Task<StudyingEntityWord> GetById(int id);
        StudyingEntityWord Update(StudyingEntityWord studyingEntityWord);
        StudyingEntityWord Add(StudyingEntityWord studyingEntityWord);
        Task<StudyingEntityWord> Delete(int id);
        bool Commit();
    }
}
