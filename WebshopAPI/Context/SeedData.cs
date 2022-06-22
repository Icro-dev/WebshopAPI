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
                        Property1 = "https://tweakers.net/i/G-lL1W0psbgesktWG1dklkxCIxk=/fit-in/188x141/filters:strip_icc():fill(white):strip_exif()/i/2004949638.jpeg?f=thumblarge",
                        Price = 1.99,
                        IsAvailable = true
                    },
                     new Products
                     {
                         Name = "Product2",
                         AvailableSince = new DateTime(2022, 05, 19, 17, 00, 00),
                         Property1 = "https://tweakers.net/i/RzYA1fYuvekmzUI7BTqO4b7RdgU=/fit-in/188x141/filters:strip_icc():fill(white):strip_exif()/i/2003991542.jpeg?f=thumblarge",
                         Price = 5,
                         IsAvailable = true
                     }, 
                     new Products
                     {
                         Name = "Product3",
                         AvailableSince = new DateTime(2022, 05, 19, 17, 00, 00),
                         Property1 = "https://tweakers.net/i/I1F29nAtsPBfcfu4MbnbnP2w2XU=/fit-in/188x141/filters:strip_icc():fill(white):strip_exif()/i/2004915316.jpeg?f=thumblarge",
                         Price = 10.50,
                         IsAvailable = true
                     }, 
                     new Products
                     {
                         Name = "Product4",
                         AvailableSince = new DateTime(2022, 05, 19, 18, 00, 00),
                         Property1 = "https://tweakers.net/i/gLy24cbSYGDKdPT2n0D8kBgyzjw=/fit-in/188x141/filters:strip_icc():fill(white):strip_exif()/i/2004417202.jpeg?f=thumblarge",
                         Price = 100,
                         IsAvailable = true
                     },
                      new Products
                      {
                          Name = "Product5",
                          AvailableSince = new DateTime(2022, 05, 19, 19, 00, 00),
                          Property1 = "https://tweakers.net/i/6zVrZgXkn-l9Erxlia8BJXD_FdQ=/fit-in/188x141/filters:strip_icc():fill(white):strip_exif()/i/2004950048.jpeg?f=thumblarge",
                          Price = 1200,
                          IsAvailable = true
                      },
                       new Products
                       {
                           Name = "Product6",
                           AvailableSince = new DateTime(2022, 05, 19, 19, 00, 00),
                           Property1 = "https://tweakers.net/i/cEB2P4yYn00pMuzCxQ11YU34EuE=/fit-in/188x141/filters:strip_icc():fill(white):strip_exif()/i/2004749082.jpeg?f=thumblarge",
                           Price = 5.99,
                           IsAvailable = true
                       }
                    );
            await context.SaveChangesAsync();
            if (!context.Users.Any() && context.Users != null)
                context.Users.AddRange(
                    new Users
                    {
                        Username = "Admin",
                        Password = "Wachtwoord1!",
                        Role = "Admin",
                        Latitude = 51.585255,
                        Longitude = 5.056375,
                        Street = "Teststraat",
                        HouseNumber = "12",
                        Zipcode = "9721JN",
                        City = "Teststad"

                    },
                     new Users
                     {
                         Username = "Customer1",
                         Password = "Wachtwoord1!",
                         Role = "Admin",
                         Latitude = 53.219383,
                         Longitude = 6.566502,
                         Street = "Heresingel",
                         HouseNumber = "1",
                         Zipcode = "9711EP",
                         City = "Groningen"
                     });
            await context.SaveChangesAsync();
            if (!context.News.Any() && context.News != null)
                context.News.AddRange(
                    new News
                    {
                        Title = "Dell kondigt nieuwe versie XPS 13 aan",
                        ArticleText = "Dell heeft een nieuwe versie van zijn XPS 13-laptop aangekondigd. De grootste vernieuwing is volgens de fabrikant het veel kleinere moederbord, waardoor de laptop lichter en krachtiger moet zijn en desondanks langer mee moet gaan op een acculading.",
                        CreatedDate = new DateTime(2022, 06, 09, 16, 00, 00),
                        Author = "Admin"
                    },
                    new News
                    {
                        Title = "ZTE Axon 40 Ultra met camera achter scherm kost 829 euro in Benelux",
                        ArticleText = "ZTE brengt op 21 juni zijn Axon 40 Ultra-smartphone uit in de Benelux. Het Android-toestel heeft een 6,8 inch - amoledscherm en de frontcamera is daarachter verwerkt. Aan de achterkant zitten drie 64 - megapixelcamera's.",
                        CreatedDate = new DateTime(2022, 06, 09, 16, 41, 00),
                        Author = "Admin"
                    });
            await context.SaveChangesAsync();
        }
    }
}
