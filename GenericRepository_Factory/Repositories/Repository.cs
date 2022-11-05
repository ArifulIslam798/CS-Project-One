using GenericRepository_Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository_Factory.Repositories
{
    public class Repository<T> : IRepository<T> where T : class,IEntity, new()
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
        public T Get(int id)
        {
            return this.list.FirstOrDefault(x=> x.Id == id);

        }
        public void Add(T entity)
        {
            this.list.Add(entity);
        }
        public void Update(T entity)
        {
            var item = this.list.FirstOrDefault(x=> x.Id == entity.Id);
            if (item != null)
            {
                var i = list.IndexOf(item);
                list.RemoveAt(i);
                list.Insert(i, entity);
            }
        }
        public void Delete(int id)
        {
            var item = this.list.FirstOrDefault(x=> x.Id == id);
            if (item != null)
            {
                var i = list.IndexOf(item);
                list.RemoveAt(i);

            }
        }
    }
 }
