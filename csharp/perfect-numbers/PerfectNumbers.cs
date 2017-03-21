public class PerfectNumbers
{
    public static NumberType Classify(int number)
    {
        var sum = 0;
        for (var i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
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