
using Catalog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace Catalog.Persistence.Database.Configuration
{
    public class ProductConfiguration
    {
        public ProductConfiguration(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.ProductId);
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.Description).IsRequired().HasMaxLength(500);
            entityBuilder.Property(x => x.Price).HasColumnType("decimal(18,2)");

            // Products by default
            var products = new List<Product>();
            var random = new Random();

            for (var i = 1; i <= 100; i++) 
            {
                products.Add(new Product { 
                    ProductId = i,
                    Name = $"Product {i}",
                    Description = $"Description for product {i}",
                    Price = random.Next(100, 1000),

                    //Stock = new ProductInStock { 
                    //    ProductInStockId = i,
                    //    ProductId = i,
                    //    Stock =random.Next(0, 100)
                   // }

                });
            }

            entityBuilder.HasData(products);

        }
    }
}
