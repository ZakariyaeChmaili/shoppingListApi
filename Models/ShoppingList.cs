using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shopping_List_api.Models
{
    public class ShoppingList
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required]
        [MaxLength(255)]
        public string ListName { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public bool IsShared { get; set; }

        [ForeignKey("Stores")]
        public int? StoreId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Stores Store { get; set; }
        public List<ShoppingListItems> ShoppingListItems { get; set; }
        public List<ShoppingListFriendsList> ShoppingListFriendsLists { get; set; }
        public List<Reminders> Reminders { get; set; }
    }
}
