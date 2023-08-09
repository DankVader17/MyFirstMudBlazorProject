using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MyFirstMudBlazorProject.Data.Models;

namespace MyFirstMudBlazorProject.Data
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options)
        { 
            
        }

        public DbSet<MyTask> MyTasks { get; set; }
    }
}
