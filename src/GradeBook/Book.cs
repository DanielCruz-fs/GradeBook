namespace GradeBook
{
    public abstract class Book : NamedObject, IBook
    {
    public Book(string name) : base(name)
    {
    }

    public abstract void AddGrade(double grade);

    public virtual Statistics GetStatistics()
    {
      throw new System.NotImplementedException();
    }
  }
}