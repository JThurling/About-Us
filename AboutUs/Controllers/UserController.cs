using System.Threading.Tasks;
using Core.Entity;
using Core.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AboutUs.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet]
        public async Task<ActionResult<UserEntity>> GetUsers()
        {
            var users = await _userService.GetUserInfo();

            return Ok(users);
        }
    }
}