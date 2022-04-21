using Microsoft.AspNetCore.Mvc;

namespace _001_Estudo_API.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("/")]
        public string Get()
        {
            return "Parabéns vc criou sua primeira API!";
            
        }
       
    }
    
}
