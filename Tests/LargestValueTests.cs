using Algorithms;

namespace Tests;

public class LargestValueTests
{
    [Theory]
    [InlineData(new int[] { 1 }, 1)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 4)]
    [InlineData(new int[] { -1, 0, 1 }, 1)]
    [InlineData(new int[] { 0, 10000 }, 10000)]
    [InlineData(new int[] { 10000, 0 }, 10000)]
    [InlineData(new int[] { 1, 1 }, 1)]
    public void CorrectnessTests(int[] values, int expected)
    {
        var actual = LargestValue.Run(values);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PerformanceTest()
    {
        Random random = new Random();
        var input = new int[100_000_000];
        for (int i = 0; i < input.Length - 1; i++)
        {
            input[i] = random.Next(0, 100000);
        }
        input[input.Length - 1] = 100000;

        var result = LargestValue.Run(input);
        Assert.Equal(100000, result);
    }
}
