using System;
using System.Collections.Generic;
using System.Linq;

public static class AccumulationExtensions
{
    public static IEnumerable<T> Accumulate<T>(this IEnumerable<T> list, Func<T, T> action)
    {
        return list.Select(action);
    }
}