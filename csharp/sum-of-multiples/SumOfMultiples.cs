using System.Linq;

public class SumOfMultiples
{
    public static int To(int[] numbers, int max)
    {
        return Enumerable
                .Range(0, max)
                .Where(i => numbers.Any(num => i % num == 0))
                .Sum();
    }
}