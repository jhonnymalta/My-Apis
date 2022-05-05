using _003_ControleDeEstoque.Data;
using _003_ControleDeEstoque.Models;
using Microsoft.AspNetCore.Mvc;

namespace _003_ControleDeEstoque.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("")]
        public string Get()
        {
            return "Enabled";
        }
        [HttpPost("v1/product")]
        public ActionResult<Produto> Post(
            [FromBody] Produto produto,
            [FromServices] AppDbContext context
            )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("As informações do produto estão inválidas.");
               
            }
            context.produtos.Add(produto);
            context.SaveChanges();
            return produto;
        }
    }
}
