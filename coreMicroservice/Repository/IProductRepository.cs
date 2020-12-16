using coreMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreMicroservice
{
    public interface IProductRepository
    {
        List<Product> GetProductDetails();
        Product GetProductById(int id);
        void InserProduct(Product product);
        void DeleteProduct(int id);
        void UpdateProduct(Product product);

        

    }
}
