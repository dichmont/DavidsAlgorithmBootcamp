namespace Algorithms;

public class RemoveAdjacentDuplicates
{
    public static int[] Run(int[] initial)
    {
        if (initial == null)
            return [];

        if (initial.Length == 0 || initial.Length == 1)
            return initial;

        var result = new List<int>() { initial[0] };
        for (int i = 1; i < initial.Length; i++)
        {
            if (initial[i] != initial[i - 1])
            {
                result.Add(initial[i]);
            }
        }
        return [.. result];
    }
}
