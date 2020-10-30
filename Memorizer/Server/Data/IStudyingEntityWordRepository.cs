using Memorizer.Server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Memorizer.Server.Data
{
    public interface IStudyingEntityWordRepository
    {
        Task<List<StudyingEntityWord>> GetAll();
        Task<StudyingEntityWord> GetById(long id);
        Task<StudyingEntityWord> Update(StudyingEntityWord studyingEntityWord);
        Task<StudyingEntityWord> Add(StudyingEntityWord studyingEntityWord);
        Task<StudyingEntityWord> Delete(long id);
        Task<bool> Commit();
    }
}
