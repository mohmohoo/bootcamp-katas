using Xunit;
using StringCalculator;

namespace StringCalculatorTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData(" , ", 0)]
        [InlineData(",,,", 0)]

        [InlineData(" ,1", 1)]

        [InlineData("1", 1)]
        [InlineData("1,2", 3)]
        [InlineData("10,20", 30)]
        [InlineData("-1,3", 2)]
        [InlineData("2147483648, 2147483648", 0)]
        [InlineData("a", 0)]
        [InlineData("a,a", 0)]
        [InlineData("a,1", 1)]
        [InlineData("A,1", 1)]
        [InlineData("A,A", 0)]
        [InlineData("-", 0)]
        [InlineData("-,1", 1)]
        public void CalculateTest(string value, int expected)
        {
            var actual = Calculator.Calculate(value);
            Assert.Equal(expected, actual);
            
        }
    }
}
