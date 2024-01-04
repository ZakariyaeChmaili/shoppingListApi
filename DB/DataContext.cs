using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Shopping_List_api.Models;

namespace Shopping_List_api.DB
{
    public class DataContext : IdentityDbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<FriendsList> FriendsLists { get; set; }
        public DbSet<ShoppingList> ShoppingLists { get; set; }
        public DbSet<Reminders> Reminders { get; set; }
        public DbSet<UserFriendsList> UserFriendsLists { get; set; }
        public DbSet<ShoppingListFriendsList> ShoppingListFriendsLists { get; set; }
        public DbSet<ShoppingListItems> ShoppingListItems { get; set; }
        public DbSet<Stores> Stores { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<ItemsStore> ItemsStores { get; set; }


    }
}
