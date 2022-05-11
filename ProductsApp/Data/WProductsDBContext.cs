using Microsoft.EntityFrameworkCore;
using ProductsApp.Models;

namespace ProductsApp.Data  
{
    public class WProductsDBContext : DbContext
    {
        
        //You must inject the db context in the constructor:
        public WProductsDBContext(DbContextOptions<WProductsDBContext> options)
            : base(options) 
        {

        }
        public DbSet<Product> Product { get; set; }

        //public DbSet<Product> O { get; set; }
    }
}
