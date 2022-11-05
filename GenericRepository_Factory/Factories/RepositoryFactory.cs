using GenericRepository_Factory.Models;
using GenericRepository_Factory.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository_Factory.Factories
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public Repository<T> Create<T>() where T : class, IEntity, new()
        {
            return Activator.CreateInstance(typeof(Repository<T>), new object[] { new List<T>() }) as Repository<T>;
        }
    }
}
