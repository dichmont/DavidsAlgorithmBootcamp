using Algorithms;

namespace Tests;

public class AddToMultipleTests
{
    [Theory]
    [InlineData(new int[] { 1, 2 }, 3, true)]
    [InlineData(new int[] { 3, 6 }, 3, true)]
    [InlineData(new int[] { 7, 8 }, 3, true)]
    [InlineData(new int[] { 1, 3 }, 3, false)]
    [InlineData(new int[] { 1, 2, 3 }, 6, false)]
    [InlineData(new int[] { 1, 4, 5 }, 4, false)]
    [InlineData(new int[] { 1 }, 1, false)]
    [InlineData(new int[] { 1, 1 }, 1, true)]
    [InlineData(new int[] { 1, 2 }, 1, true)]
    public void CorrectnessTests(int[] array, int sum, bool expected)
    {
        var actual = AddToMultiple.Run(array, sum);
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

        var falseResult = AddToMultiple.Run(input, 401);
        Assert.False(falseResult);

        var trueResult = AddToMultiple.Run(input, 50);
        Assert.True(trueResult);
    }
}
