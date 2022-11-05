using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository_Method.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        IList<T> list;
        public Repository(IList<T> list)
        {
            this.list = list;
        }
        public IList<T> GetAll()
        {
            return list;
        }
        public T Get(Func<T, bool> expression)
        {
            return this.list.FirstOrDefault(expression);
                
        }
        public void Add(T entity)
        {
            this.list.Add(entity);
        }
        public void Update(Func<T, bool> expression, T entity)
        {
            var item = this.list.FirstOrDefault(expression);
            if(item != null)
            {
                var i = list.IndexOf(item);
                list.RemoveAt(i);
                list.Insert(i, entity);
            }
        }
        public void Delete(Func<T, bool> expression)
        {
            var item = this.list.FirstOrDefault(expression);
            if (item != null)
            {
                var i = list.IndexOf(item);
                list.RemoveAt(i);
               
            }
        }

        

        

       
    }
}
