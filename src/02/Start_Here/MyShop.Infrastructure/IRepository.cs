using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MyShop.Infrastructure.Repositories
{
    public interface IRepository<T>
    {
        T Add(T entity);
        T Update(T entity);
        T Get(Guid Id);
        IEnumerable<T> All();
        IEnumerable<T> Find(Expression<Func<T,bool>> predicate);
        void SaveChanges();
    }
}