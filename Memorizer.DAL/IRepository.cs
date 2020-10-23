using System;
using System.Collections.Generic;
using System.Text;

namespace Memorizer.DAL
{
    interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(string id);
        T Update(T entety);
        T Add(T newEvent);
        T Delete(string id);
        bool Commit();
    }
}
