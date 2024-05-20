using Algorithms;

namespace Tests;

public class RemoveAdjacentDuplicatesTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
    [InlineData(new int[] { 1, 1, 1 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 1, 2, 1, 1 }, new int[] { 1, 2, 1 })]
    [InlineData(new int[] { 1 }, new int[] { 1 })]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(null, new int[] { })]

    public void CorrectnessTests(int[] input, int[] expectedOutput)
    {
        var actual = RemoveAdjacentDuplicates.Run(input);
        Assert.Equal(expectedOutput, actual);
    }
}