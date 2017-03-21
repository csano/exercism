using System;
using System.Linq;

public class Queens
{
    private readonly Queen white;
    private readonly Queen black;

    public Queens(Queen white, Queen black)
    {
        if (white.Equals(black))
        {
            throw new ArgumentException();
        }
        this.white = white;
        this.black = black;
    }

    public bool CanAttack()
    {
        var whiteQueenCoordinates = new[] { white.X, white.Y };
        var blackQueenCoordinates = new[] { black.X, black.Y };

        var list = whiteQueenCoordinates
                        .Zip(blackQueenCoordinates, (i1, i2) => new Tuple<int, int>(i1, i2))
                        .Select(x => Math.Abs(x.Item1 - x.Item2))
                        .ToList();

        return list.All(x => x == list.First()) || list.Any(x => x == 0);
    }
}

public class Queen : IEquatable<Queen>
{
    public int X { get; }
    public int Y { get; }

    public Queen(int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool Equals(Queen other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return X == other.X && Y == other.Y;
    }
}