using System;
using System.Collections.Generic;

public static class ListExtensions
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> list, Func<T, bool> expression)
    {
        foreach (var item in list)
        {
            if (expression(item))
            {
                yield return item;
            }
        }
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> list, Func<T, bool> expression)
    {
        foreach (var item in list)
        {
            if (!expression(item))
            {
                yield return item;
            }
        }
    }
}