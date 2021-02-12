using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCrudRP.Core.Domain
{
    public class Product
    {
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Tell us your name")]
        public string Name { get; set; }

        [DisplayName("Product Price")]
        [Required(ErrorMessage = "Enter the product price")]
        [Column(TypeName = "decimal(8,2)")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "Select a category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
