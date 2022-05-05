using _003_ControleDeEstoque.Models;
using Microsoft.EntityFrameworkCore;

namespace _003_ControleDeEstoque.Data
{
    public class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=003-ESTOQUE;User Id=sa;Password=1q2w3e4r@#$");

        public DbSet<Produto> produtos { get; set; }
    }
}
