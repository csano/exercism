using System.Collections.Generic;
using System.Linq;

public class Sieve
{
    public static int[] Primes(int max)
    {
        var map = new Dictionary<int, bool>();
        for (var i = 2; i <= max; i++)
        {
            if (map.ContainsKey(i)) continue;
            map[i] = true;
            for (var j = i * i; j <= max; j += i)
            {
                map[j] = false;
            }
        }
        return map.Where(x => x.Value).Select(x => x.Key).OrderBy(x => x).ToArray();
    }
}