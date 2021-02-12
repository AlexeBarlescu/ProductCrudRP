using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductCrudRP.Core.DataInterface;
using ProductCrudRP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCrudRP.Web.Pages
{
    public class IndexModel: PageModel
    {
        private readonly IProductRepository _productRepository;

        public IndexModel(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> Products { get; set; }

        public void OnGet()
        {
            Products = _productRepository.GetAll();
        }
    }
}
