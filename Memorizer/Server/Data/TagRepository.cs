using Memorizer.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace Memorizer.Server.Data
{
    public class TagRepository : ITagRepository
    {
        private readonly ApplicationDbContext ctx;
        private readonly ILogger<TagRepository> logger;

        public TagRepository(ApplicationDbContext ctx, ILogger<TagRepository> logger)
        {
            this.ctx = ctx;
            this.logger = logger;
        }

        public Tag Add(Tag tag)
        {
            ctx.Add(tag);
            return tag;
        }

        public bool Commit()
        {
            return ctx.SaveChanges() > 0;
        }

        public Tag GetById(string id)
        {
            return ctx.Tags.Find(id);
        }

        public Tag Delete(string id)
        {
            var tag = GetById(id);
            if (tag != null)
            {
                ctx.Tags.Remove(tag);
            }
            return tag;
        }

        public IEnumerable<Tag> GetAll()
        {
            return ctx.Tags.ToList();
        }

        public Tag Update(Tag tag)
        {
            var entyti = ctx.Tags.Attach(tag);
            entyti.State = EntityState.Modified;
            return tag;
        }
    }
}
