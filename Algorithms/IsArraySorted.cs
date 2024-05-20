namespace Algorithms;

public class IsArraySorted
{
    public static bool Run(int[] input)
    {
        if (input.First() > input.Last()) //descending
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] < input[i + 1])
                    return false;
            }
            return true;
        }
        else //ascending or flat
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] > input[i + 1])
                    return false;
            }
            return true;
        }
    }
}
