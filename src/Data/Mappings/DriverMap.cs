using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Data.Mappings
{
  public class DriverMap : EntityTypeConfiguration<Driver>
  {
    public DriverMap()
    {
      Map(m =>
        {
          m.ToTable("Person", "HumanResources");
          m.Requires("Type").HasValue("Driver");
        });
      Map<Student>(m => m.Requires("Type").HasValue("Student"));
      Map<Instructor>(m => m.Requires("Type").HasValue("Instructor"));

      Property(driver => driver.FirstName).HasColumnName("GivenName");
      Property(driver => driver.LastName).HasColumnName("Surname");
      Property(driver => driver.Birthday).HasColumnName("DateOfBirth");
    }
  }
}
