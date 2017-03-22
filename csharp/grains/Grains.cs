using System;
using System.Linq;

public class Grains
{
    public static ulong Total()
    {
        return Enumerable
                .Range(1, 64)
                .Aggregate<int, ulong>(0, (accumulator, x) => accumulator + Square(x));
    }

    public static ulong Square(int i)
    {
        return (ulong) Math.Pow(2, i-1);
    }
}