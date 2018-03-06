using System;
using Xunit;
using Palindrome; 

namespace PalindromeTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("madam m a d a m    ", true)]
        [InlineData("", false)]
        [InlineData("a", true)]
        [InlineData("abba", true)]
        [InlineData("  ", false)]
        [InlineData("Abba", true)]
        [InlineData("Abba?", true)]
        public void Test1(string value, bool expected)
        {
           var actual = Class1.IsPalindrome(value);
            Assert.Equal(expected, actual);
        }
    }
}
