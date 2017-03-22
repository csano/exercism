using System;
using System.Linq;
using NUnit.Framework;

public class Squares {
    
	private readonly int num;
	private const int Power = 2;

    public Squares(int num) {
        if (num < 0) {
            throw new ArgumentException();
        }
        this.num = num;
    }

    private int Iterate(Func<int, int> callback)
    {
        return Enumerable.Range(1, num).Select(callback).Sum();
    }

    public int SumOfSquares() {
        return Iterate(x => (int) Math.Pow(x, Power));
    }

    public int SquareOfSums() {
        return (int) Math.Pow(Iterate(x => x), Power);
    }

    public double DifferenceOfSquares() {
        return SquareOfSums() - SumOfSquares();
    }
}