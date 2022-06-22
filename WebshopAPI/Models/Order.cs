using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebshopAPI.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public long Id { get; set; }
        public Users? User { get; set; }
        public Products? Products { get; set; }
        public double? TotalPrice { get; set; }
    }
}
