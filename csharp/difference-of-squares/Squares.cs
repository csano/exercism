using System;
using NUnit.Framework;

public class Squares {
    
	private int num;
	private const int POWER = 2;

    public Squares(int num) {
        if (num < 0) {
            throw new ArgumentException();
        }
        this.num = num;
    }

    private int Iterate(Func<int, int> callback) {
        var output = 0;
        for(var i=1; i <= num; i++) {
            output += callback(i);
        }
        return output;
    }

    public int SumOfSquares() {
        return Iterate(x => (int) Math.Pow(x, POWER));
    }

    public int SquareOfSums() {
        return (int) Math.Pow(Iterate(x => x), POWER);
    }

    public double DifferenceOfSquares() {
        return SquareOfSums() - SumOfSquares();
    }
}