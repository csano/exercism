using System.Collections.Generic;
using System.Linq;

public class Complement
{
    private static readonly Dictionary<char, char> Dictionary = new Dictionary<char, char>
    {
        { 'G', 'C' },
        { 'C', 'G' },
        { 'T', 'A' },
        { 'A', 'U' }
    };

    public static string OfDna(string toBeConverted)
    {
        return string.Join("", toBeConverted.Select(c => Dictionary[c]).ToArray());
    }
}