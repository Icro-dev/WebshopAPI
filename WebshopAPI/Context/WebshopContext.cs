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
     /*   public DbSet<Cart> Cart { get; set; }*/
        public DbSet<News> News { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Order> Order { get; set; }
/*        public DbSet<CartItem> CartItems { get; set; }*/
    }
}
