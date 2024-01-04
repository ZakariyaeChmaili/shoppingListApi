using System.ComponentModel.DataAnnotations;

namespace Shopping_List_api.Models
{
    public class FriendsList
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
            
        public DateTime CreatedAt { get; set; } = System.DateTime.Now;

        public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public List<UserFriendsList> UserFriendsLists { get; set; }
        public List<ShoppingListFriendsList> ShoppingListFriendsLists { get; set; }
    }
}
