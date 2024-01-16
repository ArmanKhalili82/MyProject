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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Info>().HasData(
            new Info
            {
                Id = 1,
                Name = "Reza"
            },

            new Info
            {
                Id = 2,
                Name = "Amir"
            }
        );
    }
}
