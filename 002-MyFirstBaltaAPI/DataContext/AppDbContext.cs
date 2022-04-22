using _002_MyFirstBaltaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace _002_MyFirstBaltaAPI.DataContext
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder option)
            => option.UseSqlite("DataSource=Todo.db;Cache=Shared");
            

        public DbSet<ToDoModel> Todos { get; set; }



    }
}
