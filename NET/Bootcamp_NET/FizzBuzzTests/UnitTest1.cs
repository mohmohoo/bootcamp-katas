using System;
using Xunit;
using FizzBuzz;

namespace FizzBuzzTests
{
    public class UnitTest1
    {
        [Fact]
        public void IsSayingHello_IsTrue()
        {
            FizzBuzz.Class1 feelingLucky = new FizzBuzz.Class1();
            Assert.True(feelingLucky.IsSayingHello("Hello"));
        }


        [Fact]
        public void IsSayingHello_IsFalse()
        {
            FizzBuzz.Class1 feelingLucky = new FizzBuzz.Class1();
            Assert.False(feelingLucky.IsSayingHello("Goodbye"));
        }


        [Theory]
        [InlineData("Hello")]
        [InlineData("hello")]
        [InlineData("heLLO")]
        public void IsSayingHello_IsTrue_AllCases(string value)
        {
            FizzBuzz.Class1 feelingLucky = new FizzBuzz.Class1();
            Assert.True(feelingLucky.IsSayingHello(value));
        }
    }
}
