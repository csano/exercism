using System;

public class Grains
{
    public static ulong Total()
    {
        ulong sum = 0;
        for(var i = 1; i <= 64; i++)
        {
            sum += Square(i);
        }
        return sum;
    }

    public static ulong Square(int i)
    {
        return (ulong) Math.Pow(2, i-1);
    }
}