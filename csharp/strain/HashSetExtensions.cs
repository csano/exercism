using System;
using System.Collections.Generic;
using System.Linq;

public static class HashSetExtensions
{
    public static List<T> Keep<T>(this HashSet<T> hashSet, Func<T, bool> expression)
    {
        return hashSet.Where(expression).ToList();
    }

    public static List<T> Discard<T>(this HashSet<T> hashSet, Func<T, bool> expression)
    {
        return hashSet.Where(x => !expression(x)).ToList();
    }
}