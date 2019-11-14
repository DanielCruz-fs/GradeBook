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
        if (grade <= 100 && grade >= 0)
        {
          this.grades.Add(grade);
        }
        else
        {
          throw new ArgumentException($"Invalid {nameof(grade)}");
        }
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

        switch (result.Average)
        {
          case var d when d >= 90.0:
            result.Letter = 'A';
            break;
          case var d when d >= 80.0:
            result.Letter = 'B';
            break;
          case var d when d >= 70.0:
            result.Letter = 'C';
            break;
          case var d when d >= 60.0:
            result.Letter = 'D';
            break;
          default:
            result.Letter = 'F';
            break;
        }
        return result;
      }
      
      public void AddLetterGrade(char letter)
      {
        switch (letter)
        {
          case 'A':
            this.AddGrade(90);
            break;
          case 'B':
            this.AddGrade(80);
            break;
          case 'C':
            this.AddGrade(70);
            break;
          default:
            this.AddGrade(0);
            break;
        }
      }
  }
}