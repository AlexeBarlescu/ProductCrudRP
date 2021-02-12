using Microsoft.EntityFrameworkCore;
using ProductCrudRP.Core.Domain;

namespace ProductCrudRP.DataAccess
{
    public class ProductCrudRPContext : DbContext
    {
        public ProductCrudRPContext(DbContextOptions<ProductCrudRPContext> opts) : base(opts) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
