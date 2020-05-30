using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    // {
    //     public TodoContext(DbContextOptions<TodoContext> options)
    //         : base(options)
    //     {
    //     }

    //     public DbSet<TodoItem> TodoItems { get; set; }
    // }
    {
        public DbSet<TodoItem> TodoItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=sqlitedemo.db");
    }
}