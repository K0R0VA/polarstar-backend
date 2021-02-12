using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Common.models.products;
using Common.repositories;
using Microsoft.EntityFrameworkCore;

namespace PolarStar.Repositories
{
    public class DbProductRepository: IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public DbProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Product>> GetProducts() => await _context.Products.ToArrayAsync();

        public async Task<IEnumerable<Product>> GetProductsWithFilter(Product product)
        {
            return null;
        }

        public async Task<IEnumerable<Product>> SearchByName(string name) => 
            await _context.Products.Where(p => p.Name.Contains(name) || name.Contains((p.Name))).ToArrayAsync();

        public async Task<IEnumerable<Lamp>> GetLamps() => await _context.Lamps.ToArrayAsync();

        public async Task<IEnumerable<Searchlight>> GetSearchlights() => await _context.Searchlights.ToArrayAsync();

        public async Task<IEnumerable<Spotlight>> GetSpotlights() => await _context.Spotlights.ToArrayAsync();
    }
}