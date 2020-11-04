﻿using Memorizer.Server.Helpers;
using Memorizer.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
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

        public async Task<List<StudyingEntityWord>> GetAll()
        {
            return await ctx.StudyingEntityWords.Include(s => s.StudyingProcesInfo).Include(w => w.Word).ToListAsync();
        }

        public async Task<List<StudyingEntityWord>> GetAll(QueryParamiters queryParamiters)
        {
            IQueryable<StudyingEntityWord> result = ctx.StudyingEntityWords;
            if (!string.IsNullOrEmpty(queryParamiters.Value))
                result = result.Where(x => x.Word.Value.ToLower().Contains(queryParamiters.Value.ToLower()));
            if (!string.IsNullOrEmpty(queryParamiters.SortBy))
                if (typeof(StudyingEntityWord).GetProperty(queryParamiters.SortBy) != null)
                    result = result.OrderByCustom(queryParamiters.SortBy, queryParamiters.SortOrder);

            return await result.Skip(queryParamiters.Size * (queryParamiters.Page - 1)).Include(s => s.StudyingProcesInfo)
                        .Include(w => w.Word)
                        .Take(queryParamiters.Size).ToListAsync();
        }

        public async Task<StudyingEntityWord> GetById(long id)
        {
            return await ctx.StudyingEntityWords.Include(s => s.StudyingProcesInfo).Include(w => w.Word).FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<StudyingEntityWord> Add(StudyingEntityWord newStudyingEntityWord)
        {
            await ctx.AddAsync(newStudyingEntityWord);
            await Commit();
            return await GetById(newStudyingEntityWord.Id);
        }

        public async Task<StudyingEntityWord> Update(StudyingEntityWord studyingEntityWord)
        {
            var entyti = ctx.StudyingEntityWords.Attach(studyingEntityWord);
            entyti.State = EntityState.Modified;
            await Commit();
            return studyingEntityWord;
        }
        public async Task<StudyingEntityWord> Delete(long id)
        {
            var studyingEntityWord = await ctx.StudyingEntityWords.FirstOrDefaultAsync(x => x.Id == id);
            if (studyingEntityWord != null) ctx.StudyingEntityWords.Remove(studyingEntityWord);
            await Commit();
            return studyingEntityWord;
        }
        public async Task<bool> Commit()
        {
            return await ctx.SaveChangesAsync() > 0;
        }
    }
}
