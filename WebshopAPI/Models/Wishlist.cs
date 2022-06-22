/*using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebshopAPI.Models
{
    [Table("Wishlist")]
    public class Wishlist
    {

        [Key]
        public long Id { get; set; }
        public Users User { get; set; }
        public ICollection<Products> WishProductIds { get; set; }
        public bool? PriceAlert { get; set; }
        public double? PriceAlertAmount { get; set; }
        public string? PriceAlertProductName { get; set; }

    }
}
*/