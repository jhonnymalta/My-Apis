using Microsoft.AspNetCore.Mvc;

namespace _001_Estudo_API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Parabéns vc criou sua primeira API!");
            
        }
       
    }
    
}
