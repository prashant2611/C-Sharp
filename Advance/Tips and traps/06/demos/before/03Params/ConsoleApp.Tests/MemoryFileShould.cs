using Xunit;

namespace ConsoleApp.Tests
{
    public class MemoryFileShould
    {
        [Fact]
        public void ReadFile()
        {
            FileBytes file = new FileBytes("testfile.txt");

            Assert.Equal(13, file.Bytes.Length);
        }


        [Fact]
        public void SetBytes()
        {
            FileBytes file = new FileBytes("testfile.txt");

            file.Bytes[0] = 42;

            Assert.Equal(42, file.Bytes[0]);

            // For demo purposes only, this is not a good test, 
            // we are essentially testing .NET arrays
        }

    }
}
