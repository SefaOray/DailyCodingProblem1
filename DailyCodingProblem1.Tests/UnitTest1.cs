using System;
using Xunit;
using DailyCodingProblem1;

namespace DailyCodingProblem1.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] {3,4,5,6}, 9)]
        [InlineData(new int[] { 3, 4, 5, 6 }, 7)]
        [InlineData(new int[] { 3, 4, 5, 6 }, 11)]
        public void Should_return_correct_pair(int[] nums, int sum)
        {
            var result = Program.PairWithSum(nums, sum);

            Assert.Equal(2, result.Length);
            Assert.Equal(sum, result[0] + result[1]);
        }
    }
}
