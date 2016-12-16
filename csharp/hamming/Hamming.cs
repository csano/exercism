using System;
using System.Linq;

public class Hamming
{
    public static int Compute(string strand1, string strand2)
    {
        return Math.Abs(strand1.Length - strand2.Length) + strand1.Where((t, i) => t != strand2[i]).Count();
    }
}