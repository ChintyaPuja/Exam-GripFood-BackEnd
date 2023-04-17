

using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace ExamBackEnd.Entities
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Cart> Carts => Set<Cart>();
        public DbSet<CartDetail> CartDetails => Set<CartDetail>();
        public DbSet<FoodItem> FoodItems => Set<FoodItem>();
        public DbSet<Restaurant> Restaurants => Set<Restaurant>();
        public DbSet<User> Users => Set<User>();
    }
}
