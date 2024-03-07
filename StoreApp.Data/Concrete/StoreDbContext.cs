using Microsoft.EntityFrameworkCore;

namespace StoreApp.Data.Concrete
{
    public class StoreDbContext:DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options): base(options)
        {

        }

        public DbSet<Product> Products => Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Product>().HasData(
                new List<Product>(){
                    
                    new() { Id=1, Name="Product v11", Price = 1300, Description = "Nice part"},
                    new() { Id=2, Name="Product v12", Price = 2300, Description = "Nice part 12"},
                    new() { Id=3, Name="Product v13", Price = 3300, Description = "Nice part 13"},
                    new() { Id=4, Name="Product v14", Price = 4300, Description = "Nice part 14"},
                    new() { Id=5, Name="Product v15", Price = 5300, Description = "Nice part 15"},
                    new() { Id=6, Name="Product v16", Price = 6300, Description = "Nice part 16"}
                    
                }
            );
        }
    }
}