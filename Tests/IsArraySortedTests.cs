using Algorithms;

namespace Tests;

public class IsArraySortedTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, true)]
    [InlineData(new int[] { 3, 2, 1 }, true)]
    [InlineData(new int[] { 1, 1, 1 }, true)]
    [InlineData(new int[] { 1 }, true)]
    [InlineData(new int[] { 1, 3, 9 }, true)]
    [InlineData(new int[] { -1, 0, 1 }, true)]
    [InlineData(new int[] { 1, 9, 3 }, false)]
    [InlineData(new int[] { 0, 1, -2 }, false)]
    public void CorrectnessTests(int[] array, bool expected)
    {
        var actual = IsArraySorted.Run(array);
        Assert.Equal(expected, actual);
    }
}
