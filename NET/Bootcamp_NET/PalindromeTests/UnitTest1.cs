using System;
using Xunit;
using Palindrome; 

namespace PalindromeTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("", false)]
        [InlineData("  ", false)]
        [InlineData(null, false)]
        [InlineData("a", true)]
        [InlineData("abba", true)]
        [InlineData("Abba", true)]
        [InlineData("Abba?", true)]
        [InlineData("madam m a d a m    ", true)]

        [InlineData("A man, a plan, a canal, Panama!", true)]
        [InlineData("Was it a car or a cat I saw?", true)]
        [InlineData("No 'x' in Nixon", true)]
        public void IsPalindromeTest(string value, bool expected)
        {
           var actual = Class1.IsPalindrome(value);
            Assert.Equal(expected, actual);
        }
    }
}
