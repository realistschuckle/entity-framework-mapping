using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Data.Mappings
{
  public class ClassroomCourseMap : EntityTypeConfiguration<ClassroomCourse>
  {
    public ClassroomCourseMap()
    {
      ToTable("ClassroomCourses");
    }
  }
}
