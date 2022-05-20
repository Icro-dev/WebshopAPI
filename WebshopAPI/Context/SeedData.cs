using System.Text.Json;
using WebshopAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace WebshopAPI.Context
{
    public class SeedData
    {
        public static async void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new WebshopContext(
            serviceProvider.GetRequiredService<DbContextOptions<WebshopContext>>());

            if (!context.Products.Any() && context.Products != null)
                context.Products.AddRange(
                    new Products
                    {

                        Name = "Product1",
                        AvailableSince = new DateTime(2022, 05, 19, 16, 00, 00),
                        Property1 = "Property1",
                        Price = 1.99,
                        IsAvailable = true
                    },
                     new Products
                     {
                         Name = "Product2",
                         AvailableSince = new DateTime(2022, 05, 19, 17, 00, 00),
                         Property1 = "Property1",
                         Price = 5,
                         IsAvailable = true
                     }, 
                     new Products
                     {
                         Name = "Product3",
                         AvailableSince = new DateTime(2022, 05, 19, 17, 00, 00),
                         Property1 = "Property1",
                         Price = 10.50,
                         IsAvailable = true
                     }, 
                     new Products
                     {
                         Name = "Product4",
                         AvailableSince = new DateTime(2022, 05, 19, 18, 00, 00),
                         Property1 = "Property1",
                         Price = 100,
                         IsAvailable = true
                     },
                      new Products
                      {
                          Name = "Product5",
                          AvailableSince = new DateTime(2022, 05, 19, 19, 00, 00),
                          Property1 = "Property1",
                          Price = 1200,
                          IsAvailable = true
                      },
                       new Products
                       {
                           Name = "Product6",
                           AvailableSince = new DateTime(2022, 05, 19, 19, 00, 00),
                           Property1 = "Property1",
                           Price = 5.99,
                           IsAvailable = true
                       }
                    );
            await context.SaveChangesAsync();
        }
    }
}
