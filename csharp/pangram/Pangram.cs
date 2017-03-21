using System.Linq;

public class Pangram
{
    public static bool IsPangram(string sequence)
    {
        return sequence.ToLower().Where(x => x >= 'a' && x <= 'z').GroupBy(x => x).Count() == 26;
    }
}