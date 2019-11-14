using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
          var book = new Book("dan");

          var done = false;
          while (!done)
          {
            Console.WriteLine("Enter a grade or 'q' to quit.");
            var input = Console.ReadLine();

            if (input == "q")
            {
              done = true;
              continue;
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

          var result = book.GetStatistics();
          Console.WriteLine($"avg is: {result.Average}");
          Console.WriteLine($"low is: {result.Low}");
          Console.WriteLine($"high is: {result.High}");
          Console.WriteLine($"letter is: {result.Letter}");
        }
    }

}
