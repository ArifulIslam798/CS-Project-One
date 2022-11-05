using GenericRepository_Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository_Factory.Factories
{
    public class EntityFactory : IEntityFactory
    {
        public T Create<T>() where T : class, IEntity
        {
            return Activator.CreateInstance<T>();
        }
        public T Create<T>(params object[] args) where T : class, IEntity
        {
            return Activator.CreateInstance(typeof(T), args) as T;
        }
    }
}
