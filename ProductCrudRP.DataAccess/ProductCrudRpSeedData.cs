using ProductCrudRP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCrudRP.DataAccess
{
    public static class ProductCrudRpSeedData
    {
        public static void Seed(ProductCrudRPContext context)
        {
            context.Database.EnsureCreated();

            if(context.Products.Count() == 0 && context.Categories.Count() == 0)
            {
                Category c1 = new Category { Name = "Mens Footwear" };
                Category c2 = new Category { Name = "Womens Footwear" };

                context.Products.AddRange(
                    new Product
                    {
                        Name = "Leather Saddle Loafers, Tan",
                        Price = 34.00M,
                        Category = c1
                    },
                    new Product
                    {
                        Name = "Flip Flops, Red",
                        Price = 19.50M,
                        Category = c1
                    },
                    new Product
                    {
                        Name = "Almond Toe Court Shoes, Black",
                        Price = 99.00M,
                        Category = c2
                    },
                    new Product
                    {
                        Name = "Suede Shoes, Blue",
                        Price = 52.99M,
                        Category = c2
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
