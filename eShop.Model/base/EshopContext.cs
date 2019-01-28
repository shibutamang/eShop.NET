using System.Data.Entity;

namespace eShop.Model
{
    public class EshopContext : DbContext
    {
        public EshopContext() : base("eShopDbContext")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
