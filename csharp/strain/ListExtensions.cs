using System;
using System.Collections.Generic;
using System.Linq;

public static class ListExtensions
{
    public static List<T> Keep<T>(this List<T> list, Func<T, bool> expression)
    {
        return list.Where(expression).ToList();
    }
    public static List<T> Discard<T>(this List<T> list, Func<T, bool> expression)
    {
        return list.Where(x => !expression(x)).ToList();
    }
}