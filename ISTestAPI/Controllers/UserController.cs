using ISTestAPI.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ISTestAPI.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        
        [HttpGet]
        [Route("user/list")]
        public async Task<List<User>> GetAllUser()
        {
            var users = new List<User>();

            var user1 = new User
            {
                Id = 1,
                Email = "user1@email.com",
                Name = "user 1"
            };

            var user2 = new User
            {
                Id = 2,
                Email = "user2@email.com",
                Name = "user 2"
            };

            users.Add(user1);
            users.Add(user2);


            return users;
        }
    }
}
