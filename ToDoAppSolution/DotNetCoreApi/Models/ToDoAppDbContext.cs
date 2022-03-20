using Microsoft.EntityFrameworkCore;

namespace DotNetCoreApi.Models
{
    public class ToDoAppDbContext : DbContext
    {
        public ToDoAppDbContext(DbContextOptions<ToDoAppDbContext> options) : base(options)
        {

        }


        public DbSet<ToDoTask> ToDoTask { get; set; }
    }
}
