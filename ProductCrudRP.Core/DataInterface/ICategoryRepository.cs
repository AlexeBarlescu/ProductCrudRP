using ProductCrudRP.Core.Domain;

namespace ProductCrudRP.Core.DataInterface
{
    public interface ICategoryRepository
    {
        void Add(Category category);
    }
}
