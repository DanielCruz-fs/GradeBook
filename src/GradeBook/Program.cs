using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
          var book = new InMemoryBook("dan");
          // book object that interacts with files, using OOP
          // var book = new DiskBook("dan");

          EnterGrades(book);

          var result = book.GetStatistics();
          Console.WriteLine($"For the book name is: {book.Name}");
          Console.WriteLine($"The average is: {result.Average}");
          Console.WriteLine($"The lowest grade is: {result.Low}");
          Console.WriteLine($"The highest grade is: {result.High}");
          Console.WriteLine($"The letter grade is: {result.Letter}");
        }

        private static void EnterGrades(IBook book)
        {
          while (true)
          {
            Console.WriteLine("Enter a grade or 'q' to quit.");
            var input = Console.ReadLine();

            if (input == "q")
            {
              break;
            }

            try
            {
              var grade = double.Parse(input);
              book.AddGrade(grade);
            }
            catch (ArgumentException ex)
            {
              Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
              Console.WriteLine(ex.Message);
            }
            finally
            {
              Console.WriteLine("****");
            }
          }

        }
  }

}
