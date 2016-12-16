using System.Linq;

public class SumOfMultiples
{
    public static int To(int[] numbers, int max)
    {
        var output = 0;
        for (var i = 0; i < max; i++)
        {
            if (numbers.Any(num => i % num == 0))
            {
                output += i;
            }
        }
        return output;
    }
}