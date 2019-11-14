using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void CanSetNameFromReference()
        {
          var book1 = GetBook("Book1");
          this.SetName(book1, "New Name");

          Assert.Equal("New Name", book1.Name);
        }
        private void SetName(Book book1, string name)
        {
          book1.Name = name;
        }

        [Fact]
        public void GetBookReturnDifferentObjects()
        {
          var book1 = GetBook("Book1");
          var book2 = GetBook("Book2");

          Assert.Equal("Book1", book1.Name);
          Assert.Equal("Book2", book2.Name);

          Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObjects()
        {
          var book1 = GetBook("Book1");
          var book2 = book1;

          Assert.Same(book1, book2);

        }
        Book GetBook(string name)
        {
          return new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
          var book1 = GetBook("Book1");
          this.GetBookSetName(book1, "New Name");

          Assert.Equal("Book1", book1.Name);
        }
        private void GetBookSetName(Book book, string name)
        {
          book = new Book(name);
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
          var book1 = GetBook("Book1");
          this.GetBookSetNameRef(ref book1, "New Name");

          Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetNameRef(ref Book book, string name)
        {
          book = new Book(name);
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
          string name = "Scott";
          var upper = this.MakeUpperCase(name);

          Assert.Equal("Scott", name);
          Assert.Equal("SCOTT", upper);
        }
        private string MakeUpperCase(string parameter)
        {
          return parameter.ToUpper();
        }
  }
}
