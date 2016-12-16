using System;
using System.Collections.Generic;
using System.Linq;

public static class AccumulationExtensions
{
    public static IEnumerable<int> Accumulate(this int[] array, Func<int, int> action)
    {
        return array.Select(action);
    }

    public static IEnumerable<string> Accumulate(this string[] array, Func<string, string> action)
    {
        return array.Select(action);
    }

    public static IEnumerable<string> Accumulate(this List<string> list, Func<string, string> action)
    {
        return list.Select(action);
    }
}