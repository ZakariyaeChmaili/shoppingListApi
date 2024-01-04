using Shopping_List_api.DB;
using Shopping_List_api.Models;

namespace Shopping_List_api.Services
{
    public interface IAuthService
    {
        DataContext Db { get; }

        Task<User?> Authenticate(string username, string password);
    }
}