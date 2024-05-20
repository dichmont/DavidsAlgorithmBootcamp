namespace Algorithms;

public class IsPrime
{
    public static bool Run(int input)
    {
        if (input < 1)
            return false;

        for (int i = 2; i <= Math.Floor(Math.Sqrt(input)); i++)
        {
            if (input % i == 0)
                return false;
        }
        return true;
    }
}
