using CalculatorApp;

namespace CalculatorApp_Tests
{
    public class UnitTest1
    {
        // test the constructor first!
        [Fact]
        public void TestConstructor()
        {
            Calculator c1 = new Calculator(15);
            Assert.Equal(15, c1.Number);
        }

        [Theory]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]

        public void TestFindFactorial(int value, int expected)
        {
            // test factorial of 4, which is 24
            Calculator c1 = new Calculator(value);
            int actual = c1.FindFactorial();
            Assert.Equal(expected, actual);
        }
    }
}