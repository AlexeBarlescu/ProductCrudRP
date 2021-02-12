using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductCrudRP.Core.DataInterface;
using ProductCrudRP.Core.Domain;
using System.Collections.Generic;

namespace ProductCrudRP.Web.Pages.Products
{
    public class ProductPageModel : PageModel
    {
        public readonly IProductRepository _productRepository;
        public readonly ICategoryRepository _categoryRepository;

        public ProductPageModel(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public ProductFormViewModel ProducFormViewModel { get; set; }

        public IEnumerable<Category> Categories => _categoryRepository.GetAll();
    }
}
