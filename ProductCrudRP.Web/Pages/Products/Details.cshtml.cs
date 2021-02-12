using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductCrudRP.Core.DataInterface;
using ProductCrudRP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCrudRP.Web.Pages.Products
{
    public class DetailsModel: PageModel
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public DetailsModel(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public ProductFormViewModel ProducFormViewModel { get; set; }

        public void OnGet(int id)
        {
            Product p = _productRepository.Get(id);
            ProducFormViewModel = ProductFormViewModelFactory.Details(p, _categoryRepository.GetAll());
        }
    }
}
