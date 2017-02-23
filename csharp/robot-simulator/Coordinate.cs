using System.Collections.Generic;

public class Coordinate : IEqualityComparer<Coordinate>
{
    public int X { get; set; }
    public int Y { get; set; }

    public Coordinate(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override bool Equals(object obj)
    {
        return Equals(this, (Coordinate) obj);
    }

    public override int GetHashCode()
    {
        return (X << 16) ^ (Y << 8);
    }

    public bool Equals(Coordinate coordinate1, Coordinate coordinate2)
    {
        return coordinate1.X == coordinate2.X && coordinate1.Y == coordinate2.Y;
    }

    public int GetHashCode(Coordinate obj)
    {
        return obj.GetHashCode();
    }
}