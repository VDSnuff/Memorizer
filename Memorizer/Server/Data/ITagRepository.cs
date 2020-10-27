using Memorizer.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memorizer.Server.Data
{
    public interface ITagRepository
    {
        IEnumerable<Tag> GetAll();
        Tag GetById(string id);
        Tag Update(Tag studyingEntityText);
        Tag Add(Tag studyingEntityText);
        Tag Delete(string id);
        bool Commit();
    }
}
