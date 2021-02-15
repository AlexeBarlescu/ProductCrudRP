using Microsoft.AspNetCore.Mvc;
using ProductCrudRP.Core.DataInterface;
using ProductCrudRP.Core.Domain;
using System.Text.Json;

namespace ProductCrudRP.Web.Pages.Products
{
    public class CreateModel : ProductPageModel
    {
        public CreateModel(IProductRepository prodRepo, ICategoryRepository catRepo) : base(prodRepo, catRepo) { }

        public void OnGet()
        {
            Product p = TempData.ContainsKey("product")
                        ? JsonSerializer.Deserialize<Product>(TempData["product"] as string)
                        : new Product();

            ProducFormViewModel = ProductFormViewModelFactory.Create(p, Categories);
        }

        public IActionResult OnPost([FromForm] Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.Add(product);
                return RedirectToPage("/Index");
            }

            ProducFormViewModel = ProductFormViewModelFactory.Create(product, Categories);
            return Page();
        }
    }
}
