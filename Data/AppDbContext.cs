using Microsoft.EntityFrameworkCore;
using ShoppingList.Model;

namespace ShoppingList.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ShoppingItem> ShoppingItems { get; set; }
    }
}
