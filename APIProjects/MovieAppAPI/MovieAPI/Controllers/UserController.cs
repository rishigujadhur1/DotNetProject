using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.DTOs;
using MovieAPI.Entities;
using MovieAPI.Services;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<User> userManager;
        public TokenService TokenService { get; set; }
        public UserController(UserManager<User> userManager, TokenService tokenService)
        {
            this.TokenService = tokenService;
            this.userManager = userManager;
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(UserAccountDto userDto)
        {
            var user = await userManager.FindByNameAsync(userDto.Username);
            if (user == null || !await userManager.CheckPasswordAsync(user, userDto.Password))
            {
                return Unauthorized();
            }
            return new UserDto
            {
                Email = user.Email,
                Token = await TokenService.GenerateToken(user)
            };
        }
        [HttpPost("register")]
        public async Task<ActionResult> Register(UserAccountDto userDto)
        {
            var user = new User
            {
                UserName = userDto.Username,
                Email = userDto.Email
            };
            var result = await userManager.CreateAsync(user, userDto.Password);
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

        [Authorize(Roles = "Admin")]
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

        [Authorize]
        [HttpGet("currentUser")]
        public async Task<ActionResult<UserDto>> GetCurrentUser()
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            return new UserDto
            {
                Email = user.Email,
                Token = await TokenService.GenerateToken(user)
            };
        }
    }
}