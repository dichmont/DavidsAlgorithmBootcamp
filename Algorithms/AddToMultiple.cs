namespace Algorithms;

public class AddToMultiple
{
    public static bool Run(int[] input, int multipleOf)
    {
        var set = new HashSet<int>();
        foreach (int i in input)
        {
            if (i == 0)
                continue;

            var m = i % multipleOf;
            if (set.Contains(multipleOf - m))
                return true;

            if (m == 0 && set.Contains(0))
                return true;

            set.Add(m);
        }
        return false;
    }
}
