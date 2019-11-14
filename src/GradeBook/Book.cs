using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
      List<double> grades;
      string name;
      public Book(string name)
      {
        this.grades = new List<double>();     
        this.name = name;
      }
      public void AddGrade(double grade)
      {
        this.grades.Add(grade);
        Console.WriteLine($"grade: {grade} was added to {this.name}");
      }
      public void ShowStatistics()
      {
        var result = 0.0;
        var highGrade = double.MinValue;
        var lowGrade = double.MaxValue;

        foreach (var item in this.grades)
        {
          result += result + item;
          highGrade = Math.Max(item, highGrade);
          lowGrade = Math.Min(item, lowGrade);
        }
        Console.WriteLine($"total is: {result} and avg: {result / this.grades.Count}");
        Console.WriteLine($"lowest is: {lowGrade} and highest: {highGrade}");
      }
  }
}