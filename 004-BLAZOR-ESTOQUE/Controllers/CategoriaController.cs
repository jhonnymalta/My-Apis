using _004_BLAZOR_ESTOQUE.Context;
using _004_BLAZOR_ESTOQUE.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _004_BLAZOR_ESTOQUE.Controllers
{

    [ApiController]
    public class CategoriaController : ControllerBase
    {
        [HttpGet("/categoria")]

        public async Task<ActionResult<PaginationResultViewModel>> GetAsync(
            [FromServices] AppDbContext context,
            [FromQuery] int page = 0,
            [FromQuery] int pageSize = 3
            )
        {
            var count = await context.Categorias.CountAsync();
            var categorias = await context.Categorias.AsNoTracking().Skip(page * pageSize).Take(pageSize).ToListAsync();

            return Ok(new PaginationResultViewModel {
            Count = count,
            Page = page,
            PageSize = pageSize,
            categoria = categorias
            
            });
            Console.WriteLine(page);
               

            
        }


        [HttpGet("/categoria/{id}")]

        public async Task<IActionResult> GetByIdAsync(
            [FromRoute] int id, 
            [FromServices] AppDbContext context
            )
        {
            var categoria = await context.Categorias.FirstOrDefaultAsync(x => x.CategoryId == id);
            if (categoria == null) return NotFound();
            return Ok(categoria);
        }


        [HttpPost("/categoria")]
        public async Task<IActionResult> PostAsync(
       [FromBody] Categoria model,
       [FromServices] AppDbContext context)
        {
            if (model != null)
            {
                await context.Categorias.AddAsync(model);
                await context.SaveChangesAsync();

            }
            return Created($"/categoria/{model.CategoryId}", model);
        }

        [HttpPut("categoria/{id}")]
        public Categoria Put(
            [FromRoute] int id,
            [FromBody] Categoria categoria,
            [FromServices] AppDbContext context
            )
        {
            var categoriaModelo = context.Categorias.FirstOrDefault(X => X.CategoryId == id);
            if (categoriaModelo == null)
            {
                return categoria;
            }
            categoriaModelo.Name = categoria.Name;
            categoriaModelo.ShortDescription = categoria.ShortDescription;

            context.Categorias.Update(categoriaModelo);
            context.SaveChanges();
            return categoriaModelo;

        }


        [HttpDelete("categoria/{id}")]
        public Categoria DeleteAsync(
        [FromRoute] int id,
        [FromServices] AppDbContext context
        )
        {
            var model = context.Categorias.FirstOrDefault(x => x.CategoryId == id);
            context.Categorias.Remove(model);
            context.SaveChanges();

            return model;
        }



    }
}
