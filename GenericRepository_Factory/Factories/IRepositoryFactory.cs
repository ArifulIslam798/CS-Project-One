using GenericRepository_Factory.Models;
using GenericRepository_Factory.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository_Factory.Factories
{
    public interface IRepositoryFactory
    {
        Repository<T> Create<T>() where T : class, IEntity, new();
    }
}
