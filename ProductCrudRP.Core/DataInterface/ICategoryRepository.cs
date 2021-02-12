using ProductCrudRP.Core.Domain;
using System.Collections.Generic;

namespace ProductCrudRP.Core.DataInterface
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        IEnumerable<Category> GetAll();
    }
}
