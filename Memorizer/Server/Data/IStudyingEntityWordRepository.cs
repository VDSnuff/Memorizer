using Memorizer.Server.Helpers;
using Memorizer.Server.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Memorizer.Server.Data
{
    public interface IStudyingEntityWordRepository
    {
        Task<List<StudyingEntityWord>> GetAllAsync();
        Task<List<StudyingEntityWord>> GetAllAsync(QueryParamiters queryParamiters);
        Task<StudyingEntityWord> GetByIdAsync(long id);
        void Update(StudyingEntityWord studyingEntityWord);
        void Add(StudyingEntityWord studyingEntityWord);
        Task<StudyingEntityWord> DeleteAsync(long id);
        Task<bool> CommitAsync();
    }
}
