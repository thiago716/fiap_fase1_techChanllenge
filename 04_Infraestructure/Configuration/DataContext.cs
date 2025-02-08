using Core.Entity;
using Infraestructure.Configuration.Extension;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Configuration;
public class DataContext : DbContext
{
    private readonly string? _connectionString;

    public DbSet<Contact> Contacts { get; set; }
    public DbSet<DirectDistanceDialing> DirectDistanceDialings { get; set; }  

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
                
        modelBuilder.Seed();
    }
}
