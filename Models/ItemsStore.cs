using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shopping_List_api.Models
{
    public class ItemsStore
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Items")]
        public int ItemId { get; set; }

        [ForeignKey("Stores")]
        public int StoreId { get; set; }

        [Required]
        public float Price { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public Items Item { get; set; }
        public Stores Store { get; set; }
    }
}
