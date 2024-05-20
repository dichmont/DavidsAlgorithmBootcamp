namespace Algorithms;

public class AddToSum
{
    public static bool Run(int[] input, int sum)
    {
        var set = new HashSet<int>();
        foreach (int i in input)
        {
            if (set.Contains(sum - i))
                return true;

            set.Add(i);
        }
        return false;
    }
}
