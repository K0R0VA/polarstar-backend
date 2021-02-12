using Common.models;
using Common.models.order;
using Common.models.products;
using Common.models.TechnicalProperties;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PolarStar.Repositories
{
    public class ApplicationDbContext: IdentityDbContext<User>
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
        public DbSet<PersonalOrder> PersonalOrders { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<TransportService> TransportServices { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
    }
}