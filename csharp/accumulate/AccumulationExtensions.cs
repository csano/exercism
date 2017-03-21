using System;
using System.Collections.Generic;
using System.Linq;

public static class AccumulationExtensions
{
    public static IEnumerable<TReturnType> Accumulate<TInputType, TReturnType>(this IEnumerable<TInputType> enumerable, Func<TInputType, TReturnType> action)
    {
        return enumerable.Select(action);
    }
}