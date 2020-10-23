using Memorizer.Models;
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

        public StudyingEntityWord GetById(string id)
        {
            return ctx.StudyingEntityWords.Find(id);
        }

        public StudyingEntityWord Delete(string id)
        {
            var studyingEntityWord = GetById(id);
            if (studyingEntityWord != null)
            {
                ctx.StudyingEntityWords.Remove(studyingEntityWord);
            }
            return studyingEntityWord;
        }

        public IEnumerable<StudyingEntityWord> GetAll()
        {
            return ctx.StudyingEntityWords.Include(s => s.StudyingProcesInfo).Include(w => w.Word).ToList();
        }

        public StudyingEntityWord Update(StudyingEntityWord studyingEntityWord)
        {
            var entyti = ctx.StudyingEntityWords.Attach(studyingEntityWord);
            entyti.State = EntityState.Modified;
            return studyingEntityWord;
        }
    }
}
