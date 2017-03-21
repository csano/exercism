using System.Linq;

public class PerfectNumbers
{
    public static NumberType Classify(int number)
    {
        var sum = 
            Enumerable
                .Range(1, number / 2)
                .Where(x => number % x == 0)
                .Sum();

        return DetermineNumberType(number, sum);
    }

    private static NumberType DetermineNumberType(int number, int sum)
    {
        if (sum == number)
        {
            return NumberType.Perfect;
        }
        return sum > number ? NumberType.Abundant : NumberType.Deficient;
    }
}