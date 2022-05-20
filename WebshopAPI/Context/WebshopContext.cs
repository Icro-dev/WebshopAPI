using Microsoft.EntityFrameworkCore;
using WebshopAPI.Models;

namespace WebshopAPI.Context
{
    
    public class WebshopContext
        : DbContext
    {
        public WebshopContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Products> Products { get; set; }
    }
}
