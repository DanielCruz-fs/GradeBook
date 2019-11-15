using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class InMemoryBook : Book
    {
      List<double> grades;
      public InMemoryBook(string name) : base(name)
      {
        this.grades = new List<double>();     
      }
      public override void AddGrade(double grade)
      {
        if (grade <= 100 && grade >= 0)
        {
          this.grades.Add(grade);
        }
        else
        {
          throw new ArgumentException($"Invalid {nameof(grade)}");
        }
      }
      public override Statistics GetStatistics()
      {
        var result = new Statistics();

        foreach (var grade in this.grades)
        {
          result.Add(grade);
        }

        return result;
      }

  }
}