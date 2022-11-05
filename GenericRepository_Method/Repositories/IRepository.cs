using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository_Method.Repositories
{
    public interface IRepository<T> where T : class, new()
    {
        IList<T> GetAll();
        T Get(Func<T, bool> expression);
        void Add(T entity);
        void Update(Func<T, bool> expression,T entity);
        void Delete(Func<T, bool> expression);
    }
}
