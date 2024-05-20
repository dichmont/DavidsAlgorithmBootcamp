using Algorithms;

namespace Tests;

public class AddToSumTests
{
    [Theory]
    [InlineData(new int[] { 1, 2 }, 3, true)]
    [InlineData(new int[] { 1, 3 }, 3, false)]
    [InlineData(new int[] { 1, 2, 3 }, 6, false)]
    [InlineData(new int[] { 1, 4, 5 }, 4, false)]
    [InlineData(new int[] { 1 }, 1, false)]
    public void CorrectnessTests(int[] array, int sum, bool expected)
    {
        var actual = AddToSum.Run(array, sum);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PerformanceTest()
    {
        Random random = new Random();
        var input = new int[100_000_000];
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = 2 * (i % 100);
        }

        var falseResult = AddToSum.Run(input, 51);
        Assert.False(falseResult);

        var trueResult = AddToSum.Run(input, 50);
        Assert.True(trueResult);
    }
}
