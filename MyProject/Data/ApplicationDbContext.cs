using Microsoft.EntityFrameworkCore;
using MyProject.Models;

namespace MyProject.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
        
    }
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlServer(@"Server=.;DataBase=InfoTable;Encrypt=False;Integrated Security=True");

    public DbSet<Info> infos { get; set; }
}
