using System.Collections.Generic;

namespace Domain.Entities
{
  public class Student : Driver
  {
    public Student()
    {
      Scores = new HashSet<CourseGrade>();
    }

    public ICollection<CourseGrade> Scores { get; set; }
  }
}
