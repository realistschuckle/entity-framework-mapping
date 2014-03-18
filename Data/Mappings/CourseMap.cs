using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Data.Mappings
{
  public class CourseMap : EntityTypeConfiguration<Course>
  {
    public CourseMap()
    {
      ToTable("Courses");
      HasRequired(course => course.Instructor)
        .WithMany(i => i.CoursesTaught)
        .WillCascadeOnDelete(true);
    }
  }
}
