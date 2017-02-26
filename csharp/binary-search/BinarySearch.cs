using System.Collections.Generic;

public class BinarySearch
{
    private static int DoSearch(IReadOnlyList<int> input, int searchFor, int left, int right)
    {
        if (left > right)
        {
            return -1;
        }

        var midpoint = (right + left) / 2;

        if (searchFor < input[midpoint])
        {
            return DoSearch(input, searchFor, left, midpoint - 1);
        }

        if (searchFor > input[midpoint])
        {
            return DoSearch(input, searchFor, midpoint + 1, right);
        }

        return midpoint;
    }

    public static int Search(int[] input, int searchFor)
    {
        return DoSearch(input, searchFor, 0, input.Length - 1);
    }
}