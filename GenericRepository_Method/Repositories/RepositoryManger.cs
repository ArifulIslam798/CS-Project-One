using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository_Method.Repositories
{
    public class RepositoryManger : IRepositoryManger
    {
        public Repository<T> Get<T>() where T : class, new()
        {
            return new Repository<T>(new List<T>());
        }
    }
}
