using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
namespace MyShop.Infrastructure.Repositories
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        protected ShoppingContext _context;

        public GenericRepository(ShoppingContext context)
        {
            _context = context;
        }

        public T Add(T entity)
        {
            return _context.Add(entity).Entity;
        }

        public IEnumerable<T> All()
        {
            return _context.Set<T>().ToList();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().AsQueryable().Where(predicate).ToList();
        }

        public T Get(Guid Id)
        {
            return _context.Find<T>(Id);
        }

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public T Update(T entity)
        {
            return _context.Update<T>(entity).Entity;
        }
    }
}