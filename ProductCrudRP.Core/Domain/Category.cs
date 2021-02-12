using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProductCrudRP.Core.Domain
{
    public class Category
    {
        public int Id { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Enter the category name")]
        public string Name { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}