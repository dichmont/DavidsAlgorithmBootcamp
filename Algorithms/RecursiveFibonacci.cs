namespace Algorithms;

public class RecursiveFibonacci
{
    public static int Run(int i)
    {
        if (i == 0 || i == 1)
            return 1;

        return Run(i - 1) + Run(i - 2);
    }
}
