using System.Collections.Generic;
using System.Linq;

public class Triangle
{
    private static int NumberOfEqualSides(IEnumerable<decimal> sides)
    {
        var equalSides = 4 - sides.Distinct().Count();
        return equalSides == 1 ? 0 : equalSides;
    }

    public static TriangleKind Kind(decimal side1, decimal side2, decimal side3) {

        var sides = new[] { side1, side2, side3 };

        if (sides.Any(x => x <= 0) || sides.Sum() - sides.Max() <= sides.Max())
        {
            throw new TriangleException();
        }

        switch (NumberOfEqualSides(sides))
        {
            case 3:
                return TriangleKind.Equilateral;
            case 2:
                return TriangleKind.Isosceles;
            case 0:
                return TriangleKind.Scalene;
        }

        throw new TriangleException();
    }
}