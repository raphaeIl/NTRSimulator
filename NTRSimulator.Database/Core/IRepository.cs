using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTRSimulator.Database.Core
{
    public interface IRepository<T> where T : class
    {
        T? GetById(long id);

        void Add(T entity);
        
        void Remove(T entity);
     
        int SaveChanges();
    }
}
