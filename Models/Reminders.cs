using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shopping_List_api.Models
{
    public class Reminders
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ShoppingList")]
        public int ShoppingListId { get; set; }

        [Required]
        public DateTime ReminderTime { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public ShoppingList ShoppingList { get; set; }
    }
}
