using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Data.Mappings
{
  public class PracticalCourseMap : EntityTypeConfiguration<PracticalCourse>
  {
    public PracticalCourseMap()
    {
      ToTable("PracticalCourses");
      Property(course => course.Location.Street).HasColumnName("Street");
      Property(course => course.Location.City).HasColumnName("City");
    }
  }
}
