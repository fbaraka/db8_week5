using PrimeNumbers;

namespace PrimeNumbers_Tests
{
    public class UnitTest1
    {
        [Theory]
       
        [InlineData(4,7)]
        [InlineData(5,11)]
        [InlineData(100, 541)]
        [InlineData(9, 23)]
        [InlineData(5000, 48611)]
        [InlineData(9000, 93179)]

        public void TestGetPrime10(int value, int expected)
        {

            int actual = PrimeNumberGenerator.GetPrime(value);
            Assert.Equal(expected, actual);
        }



    }
}