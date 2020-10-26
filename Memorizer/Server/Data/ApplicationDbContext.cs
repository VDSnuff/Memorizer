using Memorizer.Server.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Memorizer.Models;

namespace Memorizer.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<StudyingEntityWord> StudyingEntityWords { get; set; }
        public DbSet<StudyingEntityText> StudyingEntityTexts { get; set; }
        public DbSet<StudyingProcesInfo> StudyingProcesInfos { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<Text> Texts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Language> Languages { get; set; }


    }
}
