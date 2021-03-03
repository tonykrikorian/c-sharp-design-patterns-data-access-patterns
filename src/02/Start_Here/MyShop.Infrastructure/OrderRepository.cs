using Microsoft.EntityFrameworkCore;
using MyShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MyShop.Infrastructure.Repositories
{
    public class OrderRepository: GenericRepository<Order>
    {
        public OrderRepository(ShoppingContext context):base(context)
        {
            
        }
        public override IEnumerable<Order> Find(Expression<Func<Order, bool>> predicate)
        {
          return _context.Orders
                .Include(order => order.LineItems)
                .ThenInclude(lineItem => lineItem.Product)
                .Where(predicate).ToList();

        }

        
    }
}