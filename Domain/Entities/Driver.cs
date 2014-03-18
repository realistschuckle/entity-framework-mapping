using System;

namespace Domain.Entities
{
  public class Driver
  {
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string MiddleInitial { get; set; }

    public string LastName { get; set; }

    public DateTime Birthday { get; set; }

    public EyeColor? EyeColor { get; set; }
  }
}
