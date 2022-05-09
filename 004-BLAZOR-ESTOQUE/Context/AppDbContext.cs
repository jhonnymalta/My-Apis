using _004_BLAZOR_ESTOQUE.Models;
using Microsoft.EntityFrameworkCore;

namespace _004_BLAZOR_ESTOQUE.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=BLAZOR-ESTOQUE;User ID=sa;Password=1q2w3e4r@#$");

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
