using ProductCrudRP.Core.Domain;
using System.Collections.Generic;

namespace ProductCrudRP.Web.Pages.Products
{
    public class ProductFormViewModelFactory
    {
        public static ProductFormViewModel Details(Product product, IEnumerable<Category> categories)
        {
            return new ProductFormViewModel
            {
                Product = product,
                Action = "Details",
                Theme = "info",
                ReadOnly = true,
                Categories = categories
            };
        }
    }
}
