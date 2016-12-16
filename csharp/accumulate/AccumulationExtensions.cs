using System;
using System.Collections.Generic;
using System.Linq;

public static class AccumulationExtensions
{
    public static IEnumerable<T> Accumulate<T>(this IEnumerable<T> enumerable, Func<T, T> action)
    {
        return enumerable.Select(action);
    }
}