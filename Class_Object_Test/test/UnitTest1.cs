using Class_Object_Test.GradeBook;
using System;
using Xunit;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Book bobj = new Book("Prashant's Grade Book");
            bobj.add(4.5);
            bobj.add(5.5);
            bobj.add(1.4);
            bobj.add(6.3);

            var result = bobj.getStatistics();

            Assert.Equal(4.4, result.res,1);       // 1 is use for the number after decimal point.
        }
    }
}
