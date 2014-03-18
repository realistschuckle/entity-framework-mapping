using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Data.Mappings
{
  public class CourseGradeMap : EntityTypeConfiguration<CourseGrade>
  {
    public CourseGradeMap()
    {
      ToTable("Grades");
      HasRequired(grade => grade.Course).WithMany();
      HasRequired(grade => grade.Student).WithMany(student => student.Scores).WillCascadeOnDelete(false);
    }
  }
}
