using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebshopAPI.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Role { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string? Street { get; set; }
        public string? HouseNumber { get; set; }
        public string? Zipcode { get; set; }
        public string? City { get; set; }

    }
}
