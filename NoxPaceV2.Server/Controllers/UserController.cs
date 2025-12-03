using Microsoft.AspNetCore.Mvc;
using NoxPaceV2.Server.Services;



namespace NoxPacev2.Server.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly UserService userService;
        public UserController(UserService userService)
        {
            this.userService = userService;
        }
        [HttpPost("test")]
        public async Task<IActionResult> TestAddUserAsync()
        {
            var result = await userService.AddUserExample();
            return Ok(result);

        }
    }
}
