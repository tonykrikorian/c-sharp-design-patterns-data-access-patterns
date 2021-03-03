using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MyShop.Infrastructure.Repositories
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        public T Add(T entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> All()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }

        public T Get(Guid Id)
        {
            throw new System.NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}