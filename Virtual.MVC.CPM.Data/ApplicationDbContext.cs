
using Microsoft.EntityFrameworkCore;

namespace Virtual.MVC.CPM.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
}
