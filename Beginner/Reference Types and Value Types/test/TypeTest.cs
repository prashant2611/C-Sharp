using Reference_Types_and_Value_Types.GradeBook;
using System;
using Xunit;

namespace test
{
    public class TypeTest
    {
        [Fact]
        public void Test1()
        {
            var book1 = getBook("Book1");
            var book2 = getBook("Book2");

            Assert.Equal("Book1", book1.name2);
            Assert.Equal("Book2", book2.name2);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void Test2()
        {
            var book1 = getBook("Book1");
            var book2 = book1;

            Assert.Same(book1, book2);
        }

        Book getBook(string name)
        {
            return new Book(name);
        }


        [Fact]
        public void Test3()
        {
            var book1 = getBook("Book1");
            setname(book1, "new Book");

            Assert.Equal("new Book", book1.name2);
           
        }

         void setname(Book book1, string name)
        {
            book1.name2 = name;
        }

        [Fact]
        public void Test4()
        {
            var book1 = getBook("Book1");
            getSetname(ref book1, "new Book");

            Assert.Equal("new Book", book1.name2);   // if we do not put ref in getSetname then ref then it act as a call by value 

        }

        private void getSetname(ref Book book1, string name)   
        {
            book1 = new Book(name);
        }


        [Fact]
        public void Test5()
        {
            int x;
            x = getint();
            setint(ref x);

            Assert.Equal(10, x);
        }

        private int getint()
        {
            return 5;
        }

        private void setint(ref int x)   // if we dont use ref keyword then it act as a call by value.
        {
            x = 10;
        }

        [Fact]
        public void Test6()
        {
            string name = "Prashant";
            var upper = tomakeUpper(name);

            Assert.Same("Prashant", name);
            //Assert.Same("PRASHANT", upper);         it gives an error bcz it compairs address.
            Assert.Equal("PRASHANT", upper);
        }

        string tomakeUpper(string name)          // we dont use ref here bcz it reflect the changes to main string. and it voilet the property of string. i.e string is immutable.
        {
            return name.ToUpper();
        }
    }
}
