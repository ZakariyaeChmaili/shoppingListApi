using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Shopping_List_api.DB;
using Shopping_List_api.Models;
using Shopping_List_api.Services;

namespace Shopping_List_api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AuthController
    {
        public JwtService JwtService { get; }
        public DataContext Db { get; }
        public IAuthService Auth { get; }

        public AuthController(JwtService jwtService,DataContext db,IAuthService auth)
        {
            JwtService = jwtService;
            Db = db;
            Auth = auth;
        }
        
        
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] User u)
        {
            var user = await Auth.Authenticate(u.Username, u.Password);

            if (user != null)
            {
                var token = JwtService.GenerateSecurityToken(user);
                return new OkObjectResult(new {token=token});
            }

            return new UnauthorizedObjectResult(new { Error = "Wrong Username or Password" });

        }

        //[HttpPost("register")]
        //public IActionResult Register(RegisterRequest request)
        //{
        //    var user = new User
        //    {
        //        Username = request.Username,
        //        Email = request.Email,
        //        Password = request.Password,
        //        Type = "user"
        //    };
        //    db.Users.Add(user);
        //    db.SaveChanges();
        //    return Ok();
        //}




        [HttpPost("TokenTest")]
        public string TokenTest([FromBody] string token)
        {

            var claims  = JwtService.GetTokenClaims(token);
            


            return "TokenTest";
        }


    }   


}
