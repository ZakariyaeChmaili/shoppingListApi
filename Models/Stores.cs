using System.ComponentModel.DataAnnotations;

namespace Shopping_List_api.Models
{
    public class Stores
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [MaxLength(255)]
        public string Location { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public List<ShoppingList> ShoppingLists { get; set; }
        public List<ItemsStore> ItemStores { get; set; }
    }
}
