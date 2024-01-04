using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shopping_List_api.Models
{
    public class UserFriendsList
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        [Column("Id")]
        public int UserId { get; set; }

        [ForeignKey("FriendsList")]
        public int FriendsListId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public User User { get; set; }
        public FriendsList FriendsList { get; set; }
    }
}
