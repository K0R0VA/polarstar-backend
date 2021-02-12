using System.Collections.Generic;
using System.Threading.Tasks;
using Common.models.products;
using System.Threading;

namespace Common.repositories
{
    public interface IProductRepository
    {
       Task<IEnumerable<Product>> GetProducts();
       Task<IEnumerable<Product>> GetProductsWithFilter(Product product);
       Task<IEnumerable<Product>> SearchByName(string name);
       Task<IEnumerable<Lamp>> GetLamps();
       Task<IEnumerable<Searchlight>> GetSearchlights();
       Task<IEnumerable<Spotlight>> GetSpotlights();
    }
}