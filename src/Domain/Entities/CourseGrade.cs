namespace Domain.Entities
{
  public class CourseGrade
  {
    public int Id { get; set; }

    public Student Student { get; set; }

    public Course Course { get; set; }

    public int Score { get; set; }
  }
}
