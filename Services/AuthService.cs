using Microsoft.EntityFrameworkCore;
using Shopping_List_api.DB;
using Shopping_List_api.Models;

namespace Shopping_List_api.Services
{
    public class AuthService : IAuthService
    {
        public DataContext Db { get; } 

        public AuthService(DataContext db)
        {
            Db = db;
        }
        public async Task<User?> Authenticate(string username, string password)
        {
            //var user = Db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            var user = await Db.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
            return user;
        }




    }
}
