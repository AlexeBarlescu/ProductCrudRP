using ProductCrudRP.Core.DataInterface;
using ProductCrudRP.Core.Domain;

namespace ProductCrudRP.DataAccess.Repositories
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly ProductCrudRPContext _context;

        public CategoryRepository(ProductCrudRPContext context)
        {
            _context = context;
        }

        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }
    }
}
