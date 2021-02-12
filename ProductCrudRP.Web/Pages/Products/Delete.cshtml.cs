using Microsoft.AspNetCore.Mvc;
using ProductCrudRP.Core.DataInterface;
using ProductCrudRP.Core.Domain;

namespace ProductCrudRP.Web.Pages.Products
{
    public class DeleteModel : ProductPageModel
    {
        public DeleteModel(IProductRepository prodRepo, ICategoryRepository catRepo) : base(prodRepo, catRepo) { }

        public void OnGet(int id)
        {
            Product p = _productRepository.Get(id);
            ProducFormViewModel = ProductFormViewModelFactory.Delete(p, Categories);
        }

        public IActionResult OnPost([FromForm] Product product)
        {
            _productRepository.Delete(product);
            return RedirectToPage("/Index");
        }
    }
}
