using System.Collections.Generic;
using System.Linq;

public class Raindrops
{
    private static readonly Dictionary<int, string> FactorMappings = new Dictionary<int, string> { { 3, "Pling" }, { 5, "Plang" }, { 7, "Plong" } };

    public static string Convert(int number)
    {
        var output = string.Empty;
        foreach (var factor in FactorMappings.Where(x => number % x.Key == 0))
        {
            output += factor.Value;
        }
        return !string.IsNullOrEmpty(output) ? output : number.ToString();
    }
}