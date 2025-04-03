using Microsoft.EntityFrameworkCore;
using TaskManagerBackend.Models;

namespace TaskManagerBackend.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<TaskItem> Tasks { get; set; }
  }
}
