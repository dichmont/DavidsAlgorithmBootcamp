using Algorithms;

namespace Tests;

public class IsPrimeTests
{
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(5, true)]
    [InlineData(6, false)]
    [InlineData(7, true)]
    [InlineData(8, false)]
    [InlineData(9, false)]
    [InlineData(10, false)]
    [InlineData(101361, false)]
    [InlineData(101363, true)]
    public void CorrectnessTests(int a, bool expected)
    {
        var result = IsPrime.Run(a);
        Assert.Equal(expected, result);
    }
}
