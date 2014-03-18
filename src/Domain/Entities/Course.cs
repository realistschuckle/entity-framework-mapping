using System.Collections.Generic;

namespace Domain.Entities
{
  public class Course
  {
    public int Id { get; set; }

    public ICollection<CourseGrade> Grades { get; set; }

    public Instructor Instructor { get; set; }

    public string Name { get; set; }
  }
}
