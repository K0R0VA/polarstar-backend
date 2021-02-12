using System.Collections.Generic;
using System.Threading.Tasks;
using Common.models.products;
using System.Threading;
using Common.models.filters;

namespace Common.repositories
{
    public interface IProductRepository
    {
       Task<IEnumerable<Product>> GetProducts();
       Task<IEnumerable<Lamp>> GetLampsWithFilter(LampFilter filter);
       Task<IEnumerable<Searchlight>> GetSearchlightsWithFilter(SearchlightFilter filter);

       Task<IEnumerable<Spotlight>> GetSpotlightWithFilter(SpotlightFilter filter);
       Task<IEnumerable<Product>> GetProductsWithFilter(ProductFilter filter);
       Task<IEnumerable<Product>> SearchByName(string name);
       Task<IEnumerable<Lamp>> GetLamps();
       Task<IEnumerable<Searchlight>> GetSearchlights();
       Task<IEnumerable<Spotlight>> GetSpotlights();
    }
}