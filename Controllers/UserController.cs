using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopping_List_api.DB;
using Shopping_List_api.Models;

namespace Shopping_List_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[Authorize]

    public class UserController(DataContext db)
    {
        //[HttpGet]
        //public List<User> GetUsersm()
        //{
        //    List<User> users = db.Users.ToList();
        //    return users;
        //}


        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await db.Users.ToArrayAsync();
            return new OkObjectResult(users.ToArray());
        }

        [HttpGet]
        public async Task<IActionResult> GetUserById(int userId)
        {
            var user = await db.Users.FindAsync(userId);
            return new OkResultObject(user);
        }

    }
}
