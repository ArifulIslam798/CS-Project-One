using GenericRepository_Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository_Factory.Factories
{
    public interface IEntityFactory
    {
        T Create<T>() where T : class, IEntity;
        T Create<T>(params object[] args) where T : class, IEntity;
    }
}
