using Microsoft.EntityFrameworkCore;

namespace TodoAPI.entities
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<Todo> Todos { get; set; }
    }
}