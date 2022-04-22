using _002_MyFirstBaltaAPI.DataContext;
using _002_MyFirstBaltaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace _002_MyFirstBaltaAPI.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("/")]
        public List<ToDoModel> GET(
            [FromServices] AppDbContext context
            )
        {
            return context.Todos.ToList();
        }

        [HttpPost("/")]
        public ToDoModel Post(
            [FromBody] ToDoModel todo,
            [FromServices] AppDbContext context
            )
        {
            context.Todos.Add(todo);
            context.SaveChanges();
            return todo;
        }
    }
}
