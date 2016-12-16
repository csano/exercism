using System.Linq;

public class Pangram
{
    public static bool IsPangram(string sequence)
    {
        var checklist = new bool[26];
        foreach (var c in sequence.ToLower().Where(x => x >= 'a' && x <= 'z'))
        {
            checklist[c - 'a'] = true;
        }
        return !checklist.Any(x => !x);
    }
}