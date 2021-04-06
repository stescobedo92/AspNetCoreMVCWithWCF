using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AspNetCoreMVCWithWCF
{
    public class ProductService : IProductService
    {
        public Product find()
        {
            return new Product { Id = "p01", Name = "Product 1", Price = 123 };
        }

        public List<Product> findAll()
        {
            return new List<Product>
            {
                new Product { Id = "p01", Name = "Product 1", Price = 123 },
                new Product { Id = "p02", Name = "Product 2", Price = 124 },
                new Product { Id = "p03", Name = "Product 3", Price = 125 }
            };
        }
    }
}
