using System.IO;

namespace GradeBook
{
  public class DiskBook : Book
  {
    public DiskBook(string name) : base(name)
    {
    }

    public override void AddGrade(double grade)
    {
      // better way to handle files instead of dispose, for IDisposable objects only
      // useful when working with files or sockets
      using (var writer = File.AppendText($"{ this.Name }.txt"))
      {
        writer.WriteLine(grade);
      }
      // writer.Dispose(); to close and free sources, using does it automatically
    }

    public override Statistics GetStatistics()
    {
      var result = new Statistics();

      using (var reader = File.OpenText($"{this.Name}.txt"))
      {
        var line = reader.ReadLine();
        while (line != null)
        {
          var number = double.Parse(line);
          result.Add(number);
          line = reader.ReadLine();
        }
      }

      return result;
    }
  }
}