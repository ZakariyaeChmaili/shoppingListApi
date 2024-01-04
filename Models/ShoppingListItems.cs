using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shopping_List_api.Models
{
    public class ShoppingListItems
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Quantity { get; set; }

        [ForeignKey("Items")]
        public int ItemsId { get; set; }

        [ForeignKey("ShoppingList")]
        public int ShoppingListId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public Items Item { get; set; }
        public ShoppingList ShoppingList { get; set; }
    }
}
