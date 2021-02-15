using Microsoft.AspNetCore.Mvc;
using ProductCrudRP.Core.DataInterface;
using ProductCrudRP.Core.Domain;
using System.Text.Json;

namespace ProductCrudRP.Web.Pages.Products
{
    public class EditModel : ProductPageModel
    {
        public EditModel(IProductRepository prodRepo, ICategoryRepository catRepo) : base(prodRepo, catRepo) { }

        public void OnGet(int id)
        {
            Product p = TempData.ContainsKey("product")
                        ? JsonSerializer.Deserialize<Product>(TempData["product"] as string)
                        : _productRepository.Get(id);

            ProducFormViewModel = ProductFormViewModelFactory.Edit(p, Categories);
        }

        public IActionResult OnPost([FromForm] Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.Edit(product);
                return RedirectToPage("/Index");
            }

            ProducFormViewModel = ProductFormViewModelFactory.Edit(product, Categories);
            return Page();
        }
    }
}
