namespace GradeBook
{
    public abstract class Book : NamedObject, IBook
    {
    public Book(string name) : base(name)
    {
    }

    public abstract void AddGrade(double grade);

    /* this implemetation is coming from IBook interface
       then we use virtual key word to override it for
       other classes implementation
    */
    // public virtual Statistics GetStatistics()
    // {
    //   throw new System.NotImplementedException();
    // }
    
    // simpler way
    public abstract Statistics GetStatistics();
  }
}