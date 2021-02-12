using ProductCrudRP.Core.Domain;
using System.Collections.Generic;

namespace ProductCrudRP.Web.Pages.Products
{
    public class ProductFormViewModel
    {
        public Product Product { get; set; }
        public string Action { get; set; }
        public string Theme { get; set; }
        public bool ReadOnly { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
