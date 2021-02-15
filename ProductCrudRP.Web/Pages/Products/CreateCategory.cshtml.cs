using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductCrudRP.Core.DataInterface;
using ProductCrudRP.Core.Domain;
using System.Text.Json;

namespace ProductCrudRP.Web.Pages.Products
{
    public class CategoryModel : PageModel
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryModel(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public string ProductId { get; set; }
        public string ReturnPage { get; set; }
        public Category Category { get; set; }

        public void OnGet([FromQuery] Product product, string returnPage)
        {
            TempData["returnPage"] = ReturnPage = returnPage;
            TempData["product"] = JsonSerializer.Serialize(product);
            TempData["productId"] = ProductId = product.Id.ToString();
        }

        public IActionResult OnPost([FromForm] Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryRepository.Add(category);
                Product p = JsonSerializer.Deserialize<Product>(TempData["product"] as string);
                p.CategoryId = category.Id;
                TempData["product"] = JsonSerializer.Serialize(p);

                return RedirectToPage(TempData["returnPage"] as string, new { id = p.Id });
            }

            Category = category;
            ProductId = TempData["productId"] as string;
            ReturnPage = TempData["returnPage"] as string;
            return Page();
        }
    }
}
