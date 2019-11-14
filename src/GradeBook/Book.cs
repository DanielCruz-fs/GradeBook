using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
      List<double> grades;
      public string Name;
      public Book(string name)
      {
        this.grades = new List<double>();     
        this.Name = name;
      }
      public void AddGrade(double grade)
      {
        this.grades.Add(grade);
      }
      public Statistics GetStatistics()
      {
        var result = new Statistics();
        result.High = double.MinValue;
        result.Low = double.MaxValue;
        result.Average = 0.0;

        foreach (var grade in this.grades)
        {
          result.Average += grade;
          result.High = Math.Max(grade, result.High);
          result.Low = Math.Min(grade, result.Low);
        }

        result.Average /= this.grades.Count;

        return result;
      }
  }
}