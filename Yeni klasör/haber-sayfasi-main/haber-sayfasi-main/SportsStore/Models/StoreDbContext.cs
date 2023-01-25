using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models {
    public class StoreDbContext : DbContext {

        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<HaberleriEkleModelClass> HaberleriEkleModelClass { get; set; }
        public DbSet<HaberlerModelClass> News { get; set; }
    }
}
