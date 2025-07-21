using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UserService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        // Protected endpoint
        [HttpGet("profile")]
        [Authorize]
        public IActionResult GetUserProfile()
        {
            var username = User.Identity?.Name ?? "Unknown";
            return Ok(new
            {
                Message = "User profile fetched successfully!",
                Username = username
            });
        }
    }
}
