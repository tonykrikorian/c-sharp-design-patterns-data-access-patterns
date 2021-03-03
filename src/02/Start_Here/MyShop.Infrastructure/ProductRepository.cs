using System.Linq;
using MyShop.Domain.Models;

namespace MyShop.Infrastructure.Repositories
{
    public class ProductRepository :GenericRepository<Product>
    {
        public ProductRepository(ShoppingContext context):base(context)
        {
            
        }

        public override Product Update(Product entity)
        {
            var product = _context.Products.Single(p => p.ProductId == entity.ProductId);
            
            product.Name = product.Name;
            product.Price = entity.Price;

            return base.Update(product);
        }
    }
}
