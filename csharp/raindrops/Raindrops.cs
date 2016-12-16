using System.Collections.Generic;
using System.Linq;

public class Raindrops
{
    private static readonly int[] Factors = { 3, 5, 7 };
    private static readonly Dictionary<int, string> FactorMappings = new Dictionary<int, string> { { 3, "Pling" }, { 5, "Plang" }, { 7, "Plong" } };

    public static string Convert(int number)
    {
        var output = string.Empty;
        foreach (var factor in Factors.Where(x => number % x == 0))
        {
            output += FactorMappings[factor];
        }
        return !string.IsNullOrEmpty(output) ? output : number.ToString();
    }
}