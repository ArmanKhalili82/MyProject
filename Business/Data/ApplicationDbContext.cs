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

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    IConfigurationRoot configuration = new ConfigurationBuilder()
    //        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    //        .AddJsonFile("appsettings.json")
    //        .Build();
    //    optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
    //}

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
