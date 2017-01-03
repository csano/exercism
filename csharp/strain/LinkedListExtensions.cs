using System;
using System.Collections.Generic;
using System.Linq;

public static class LinkedListExtensions
{
    public static List<T> Keep<T>(this LinkedList<T> list, Func<T, bool> expression)
    {
        return list.Where(expression).ToList();
    }

    public static List<T> Discard<T>(this LinkedList<T> list, Func<T, bool> expression)
    {
        return list.Where(node => !expression(node)).ToList();
    }
}