using System;
using System.Collections.Generic;
using System.Linq;

public static class ArrayExtensions
{
    public static List<T> Keep<T>(this T[] array, Func<T, bool> expression)
    {
        return array.Where(expression).ToList();
    }

    public static List<T> Discard<T>(this T[] array, Func<T, bool> expression)
    {
        return array.Where(x => !expression(x)).ToList();
    }
}