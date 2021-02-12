using Microsoft.EntityFrameworkCore;
using ProductCrudRP.Core.DataInterface;
using ProductCrudRP.Core.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ProductCrudRP.DataAccess.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly ProductCrudRPContext _context;

        public ProductRepository(ProductCrudRPContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.Include(p => p.Category).ToList();
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Edit(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void Delete(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

    }
}
