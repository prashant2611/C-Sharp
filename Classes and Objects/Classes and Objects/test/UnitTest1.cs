using System;
using Xunit;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var x=5;
            var y=4;
            var expected=20;
            var actual=x*y;

            Assert.Equal(expected,actual);
            
        }
    }
}
