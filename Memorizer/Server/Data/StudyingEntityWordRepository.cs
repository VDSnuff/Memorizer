using Memorizer.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memorizer.Server.Data
{
    public class StudyingEntityWordRepository : IStudyingEntityWordRepository
    {
        private readonly ApplicationDbContext ctx;
        private readonly ILogger<StudyingEntityWordRepository> logger;

        public StudyingEntityWordRepository(ApplicationDbContext ctx, ILogger<StudyingEntityWordRepository> logger)
        {
            this.ctx = ctx;
            this.logger = logger;
        }

        public StudyingEntityWord Add(StudyingEntityWord newStudyingEntityWord)
        {
            ctx.Add(newStudyingEntityWord);
            return newStudyingEntityWord;
        }

        public bool Commit()
        {
            return ctx.SaveChanges() > 0;
        }

        public async Task<StudyingEntityWord> GetById(int id)
        {
            return await ctx.StudyingEntityWords.FindAsync(id);
        }

        public Task<StudyingEntityWord> Delete(int id)
        {
            var studyingEntityWord = GetById(id);
            ctx.StudyingEntityWords.Remove(studyingEntityWord.Result);
            Commit();
            return studyingEntityWord;
        }

        public async Task<List<StudyingEntityWord>> GetAll()
        {
            return await ctx.StudyingEntityWords.Include(s => s.StudyingProcesInfo).Include(w => w.Word).ToListAsync();
        }

        public StudyingEntityWord Update(StudyingEntityWord studyingEntityWord)
        {
            var entyti = ctx.StudyingEntityWords.Attach(studyingEntityWord);
            entyti.State = EntityState.Modified;
            return studyingEntityWord;
        }
    }
}
