using ProductCrudRP.Core.DataInterface;
using ProductCrudRP.Core.Domain;

namespace ProductCrudRP.Web.Pages.Products
{
    public class DetailsModel : ProductPageModel
    {
        public DetailsModel(IProductRepository prodRepo, ICategoryRepository catRepo) : base(prodRepo, catRepo) { }

        public void OnGet(int id)
        {
            Product p = _productRepository.Get(id);
            ProducFormViewModel = ProductFormViewModelFactory.Details(p, Categories);
        }
    }
}
