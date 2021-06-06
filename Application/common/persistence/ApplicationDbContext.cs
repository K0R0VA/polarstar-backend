using Core.entities.order;
using Core.entities.products;
using Core.entities.TechnicalProperties;
using Core.entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Application.common.persistence
{
    public class ApplicationDbContext: IdentityDbContext<User, IdentityRole<int>, int>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Lamp> Lamps { get; set; }
        public DbSet<Searchlight> Searchlights { get; set; }
        public DbSet<Spotlight> Spotlights { get; set; }
        public DbSet<LightSource> LightSources { get; set; }
        public DbSet<Plinth> Plinths { get; set; }
        public DbSet<Protection> Protections { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartLine> CartLines { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CompanyOrder> CompanyOrders { get; set; }
        // public DbSet<Message> Messages { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<TransportService> TransportServices { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
    }
}