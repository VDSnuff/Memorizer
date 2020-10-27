using Memorizer.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace Memorizer.Server.Data
{
    public class StudyingEntityTextRepository : IStudyingEntityTextRepository
    {
        private readonly ApplicationDbContext ctx;
        private readonly ILogger<StudyingEntityTextRepository> logger;

        public StudyingEntityTextRepository(ApplicationDbContext ctx, ILogger<StudyingEntityTextRepository> logger)
        {
            this.ctx = ctx;
            this.logger = logger;
        }

        public StudyingEntityText Add(StudyingEntityText studyingEntityText)
        {
            ctx.Add(studyingEntityText);
            return studyingEntityText;
        }

        public bool Commit()
        {
            return ctx.SaveChanges() > 0;
        }

        public StudyingEntityText GetById(int id)
        {
            return ctx.StudyingEntityTexts.Find(id);
        }

        public StudyingEntityText Delete(int id)
        {
            var studyingEntityText = GetById(id);
            if (studyingEntityText != null)
            {
                ctx.StudyingEntityTexts.Remove(studyingEntityText);
            }
            return studyingEntityText;
        }

        public IEnumerable<StudyingEntityText> GetAll()
        {
            return ctx.StudyingEntityTexts.Include(s => s.StudyingProcesInfo).Include(t => t.Text).ToList();
        }

        public StudyingEntityText Update(StudyingEntityText studyingEntityText)
        {
            var entyti = ctx.StudyingEntityTexts.Attach(studyingEntityText);
            entyti.State = EntityState.Modified;
            return studyingEntityText;
        }
    }
}
