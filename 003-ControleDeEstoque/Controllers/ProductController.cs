using _003_ControleDeEstoque.Data;
using _003_ControleDeEstoque.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        [HttpGet("v1/product")]
        public async Task<IActionResult> GetAll(
            [FromServices] AppDbContext context
            )
        {
            var Produtos = await context.produtos.ToListAsync();
            return Ok(Produtos);
        } 
        [HttpGet("v1/product/{id:int}")]
        public async Task<IActionResult> GetById(
            [FromRoute] int id,
            [FromServices] AppDbContext context
            )
        {
            var produto = await context.produtos.FirstOrDefaultAsync(x => x.Id == id);

            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
            
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
        [HttpPut("v1/product/{id:int}")]
        public Produto Put(
            [FromRoute]int id,
            [FromBody] Produto produto,
            [FromServices] AppDbContext context
            )
        {
            var modelo = context.produtos.FirstOrDefault(x => x.Id == id);
            if(modelo == null)
            {
                return produto;
            }
            modelo.Name = produto.Name;
            modelo.shortDescription = produto.shortDescription;
            modelo.Price = produto.Price;
            modelo.Quantity = produto.Quantity;

            context.produtos.Update(modelo);
            context.SaveChanges();
            return modelo;
        }

        [HttpDelete("v1/product/{id:int}")]
        public async Task<Produto> Delete(
             [FromRoute] int id,
             [FromServices] AppDbContext context
            )
        {
           var model = context.produtos.FirstOrDefault(x => x.Id == id);
            context.produtos.Remove(model);
            context.SaveChanges();
            return model;
        }
    }
}
