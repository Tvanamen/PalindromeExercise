using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Hello", false)]
        [InlineData("civic", true)]
        [InlineData("12321", false)]
        [InlineData("africa", false)]
        [InlineData("fiRePlace", false)]
        [InlineData("radar", true)]
        [InlineData("Tacocat", true)]
        [InlineData("leveL", true)]
        public void Test1(string word, bool expected)
        {
            //arrange
            var palindrome = new PalindromeExercise.WordSmith();
            //act
            var actual = palindrome.IsAPalindrome(word);
            // assert
            Assert.Equal(expected, actual);
        }
    }
}
