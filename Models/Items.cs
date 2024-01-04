using System.ComponentModel.DataAnnotations;

namespace Shopping_List_api.Models
{
    public class Items
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Category { get; set; }

        [MaxLength(255)]
        public string Picture { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public List<ShoppingListItems> ShoppingListItems { get; set; }
        public List<ItemsStore> ItemStores { get; set; }
    }
}
