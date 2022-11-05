using GenericRepository_Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository_Factory.Repositories
{
    public interface IRepository<T> where T : class,IEntity, new()
    {
        IList<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
