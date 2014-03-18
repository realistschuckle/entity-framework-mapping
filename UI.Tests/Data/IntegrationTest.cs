using System;
using System.Collections.Generic;
using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;

namespace UI.Tests.Data
{
  [TestClass]
  public class IntegrationTest
  {
    [TestMethod]
    public void Test()
    {
      Student student = new Student
      {
        FirstName = "Morgan",
        LastName = "Freeman",
        Birthday = new DateTime(1944, 9, 22),
        EyeColor = EyeColor.Hazel
      };

      Instructor instructor = new Instructor
      {
        FirstName = "Martin",
        LastName = "Freeman",
        Birthday = new DateTime(1966, 1, 13)
      };

      ClassroomCourse course = new ClassroomCourse
      {
        Instructor = instructor,
        Name = "Driving Mr. Daisy",
        RoomNumber = "123"
      };

      CourseGrade grade = new CourseGrade
      {
        Score = 5,
        Course = course
      };

      student.Scores.Add(grade);

      using(var context = new DriversEdContext())
      {
        context.Drivers.Add(student);
        context.SaveChanges();
      }
    }
  }
}
