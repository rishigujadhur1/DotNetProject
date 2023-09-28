using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Entities;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<User> userManager;
        public UserController(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }

        [HttpPost("login")]
        public async Task<ActionResult<User>> Login(string username, string password)
        {
            var user = await userManager.FindByNameAsync(username);
            if (user == null || !await userManager.CheckPasswordAsync(user, password))
            {
                return Unauthorized();
            }
            return user;
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register(string username, string email, string password)
        {
            var user = new User
            {
                UserName = username,
                Email = email
            };
            var result = await userManager.CreateAsync(user, password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return ValidationProblem();
            }
            await userManager.AddToRoleAsync(user, "Member");
            return StatusCode(201);
        }


        [HttpPost("AddAdminUser")]
        public async Task AddAdminUser(string username)
        {
            var admin = new User
            {
                UserName = username,
                Email = username + "@codementor.mu"
            };
            await userManager.CreateAsync(admin, "Pas$$w0rd");
            await userManager.AddToRolesAsync(admin, new[] { "Admin", "Member" });
        }
    }
}