using Algorithms;

namespace Tests;

public class RecursiveFibonacciTests
{
    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(4, 5)]
    [InlineData(5, 8)]
    [InlineData(6, 13)]
    [InlineData(7, 21)]
    public void CorrectnessTests(int nth, int expected)
    {
        var actual = RecursiveFibonacci.Run(nth);
        Assert.Equal(expected, actual);
    }
}
