using Microsoft.EntityFrameworkCore;
using MenuApi.Models;

namespace MenuApi.Data
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
        {
        }

        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<OrderItemModel> OrderItems { get; set; }
        public DbSet<ProductModel> Menu { get; set; }

    }
}
