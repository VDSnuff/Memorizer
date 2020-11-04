using IdentityServer4.EntityFramework.Options;
using Memorizer.Server.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudyingEntityWord>().ToTable("StudyingEntityWords");
            modelBuilder.Entity<StudyingEntityText>().ToTable("StudyingEntityTexts");

            modelBuilder
                        .Entity<StudyingEntityWord>()
                        .Property(e => e.StudyingDataType)
                        .HasConversion(
                                        v => v.ToString(),
                                        v => (StudyingDataType)Enum.Parse(typeof(StudyingDataType), v));

            modelBuilder
                        .Entity<StudyingEntityText>()
                        .Property(e => e.StudyingDataType)
                        .HasConversion(
                                        v => v.ToString(),
                                        v => (StudyingDataType)Enum.Parse(typeof(StudyingDataType), v));

            modelBuilder
                        .Entity<StudyingProcesInfo>()
                        .Property(e => e.LearningStatus)
                        .HasConversion(
                                        v => v.ToString(),
                                        v => (LearningStatus)Enum.Parse(typeof(LearningStatus), v));
        }
    }
}
