using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebshopAPI.Models
{
    [Table("News")]
    public class News
    {
        
        [Key]
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? ArticleText { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Author { get; set; }

    }
}
