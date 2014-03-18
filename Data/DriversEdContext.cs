using Data.Mappings;
using Domain.Entities;
using System.Data.Entity;

namespace Data
{
  public class DriversEdContext : DbContext
  {
    public DriversEdContext()
    {
      // Database.SetInitializer<DriversEdContext>(null);
    }

    public DbSet<Driver> Drivers { get; set; }

    public DbSet<Course> Courses { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.Configurations.AddFromAssembly(typeof(DriversEdContext).Assembly);
    }
  }
}
