using System;

public class RobotSimulator
{
    public RobotSimulator(Bearing direction, Coordinate coordinate)
    {
        Direction = direction;
        Coordinate = coordinate;
    }

    public Coordinate Coordinate { get; }
    public Bearing Direction { get; set; }

    public void Simulate(string directions)
    {
        foreach (var move in directions.ToCharArray())
        {
            switch (move)
            {
                case 'L':
                    TurnLeft();
                    break;
                case 'R':
                    TurnRight();
                    break;
                case 'A':
                    Advance();
                    break;
            }
        }
    }

    private void Advance()
    {
        switch (Direction)
        {
            case Bearing.North:
                Coordinate.Y++;
                break;
            case Bearing.East:
                Coordinate.X++;
                break;
            case Bearing.West:
                Coordinate.X--;
                break;
            case Bearing.South:
                Coordinate.Y--;
                break;
            default:
                throw new Exception();
        }
    }

    public void TurnLeft()
    {
        var current = ((int) Direction - 1) % 4;
        Direction = current == -1 ? Bearing.West : (Bearing) current;
    }

    public void TurnRight()
    {
        Direction = (Bearing) (((int) Direction + 1) % 4);
    }
}