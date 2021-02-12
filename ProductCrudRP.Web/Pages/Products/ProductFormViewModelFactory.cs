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
        public static ProductFormViewModel Create(Product product, IEnumerable<Category> categories)
        {
            return new ProductFormViewModel
            {
                Product = product,
                Action = "Create",
                Theme = "primary",
                ReadOnly = false,
                Categories = categories
            };
        }
        public static ProductFormViewModel Edit(Product product, IEnumerable<Category> categories)
        {
            return new ProductFormViewModel
            {
                Product = product,
                Action = "Edit",
                Theme = "warning",
                ReadOnly = false,
                Categories = categories
            };
        }
        public static ProductFormViewModel Delete(Product product, IEnumerable<Category> categories)
        {
            return new ProductFormViewModel
            {
                Product = product,
                Action = "Delete",
                Theme = "danger",
                ReadOnly = true,
                Categories = categories
            };
        }
    }
}
