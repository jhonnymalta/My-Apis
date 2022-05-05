using _002_MyFirstBaltaAPI.DataContext;
using _002_MyFirstBaltaAPI.Models;
using _002_MyFirstBaltaAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecureIdentity.Password;

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
        //[Authorize(Roles = "admin")]
        //[HttpGet("v1/user")]
        //public IActionResult GetUser()
        //{
        //    return Ok(User.Identity.Name);
        //}
        //[HttpPost("v1/newuser")]
        //public async Task<IActionResult> Login(
        //    [FromBody] User user,
        //    [FromServices] AppDbContext constext
        //    )
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest("Modelo de usuário inválido");
        //    }
        //    var password = user.PasswordHash;
        //    user.PasswordHash = PasswordHasher.Hash(password);
        //    try
        //    {
                

        //    }
        //    catch (expt ex) { }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        }
    }

