using ProductCrudRP.Core.Domain;
using System.Collections.Generic;

namespace ProductCrudRP.Core.DataInterface
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        void Add(Product product);
        void Edit(Product product);
        void Delete(Product product);
    }
}
