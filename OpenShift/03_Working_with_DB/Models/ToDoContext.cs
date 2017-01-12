
using Microsoft.EntityFrameworkCore;

namespace HelloReact.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext()
        {}
        public ToDoContext(DbContextOptions<ToDoContext> options) :
            base(options)
        { }
        
        public DbSet<ToDo> ToDo { get; set; }
    }
}