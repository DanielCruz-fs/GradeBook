using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
          var book = new Book("dan");
          book.AddGrade(34.34);
          book.AddGrade(33.34);
          book.AddGrade(12.34);
          book.AddGrade(89.34);
          book.ShowStatistics();
        }
    }

}
