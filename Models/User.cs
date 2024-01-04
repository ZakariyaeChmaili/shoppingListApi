using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Shopping_List_api.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

 
        [MaxLength(255)]
        public string? Username { get; set; }


        [MaxLength(255)]
        [EmailAddress]
        public string? Email { get; set; }


        [MaxLength(255)]
        public string? Password { get; set; }
        
        [MaxLength(50)]
        public string? Type { get; set; }

        [AllowNull]
        public DateTime? CreatedAt { get; set; }

        [AllowNull]
        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        public List<UserFriendsList>? FriendsLists { get; set; }
        public List<ShoppingList>? ShoppingLists { get; set; }
    }
}
