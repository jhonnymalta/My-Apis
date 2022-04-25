using _002_MyFirstBaltaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace _002_MyFirstBaltaAPI.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        
        [HttpGet("v1/login")]
        public IActionResult Login(
            [FromServices] TokenService tokenService
            )
        {
            var token = tokenService.GenerateToken(null);
            return Ok(token);
        }
    }
}
