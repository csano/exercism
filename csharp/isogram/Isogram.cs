using System.Linq;

public class Isogram
{
    public static bool IsIsogram(string input)
    {
        var eligibleCharacters = input.ToLower().Where(char.IsLetterOrDigit).ToArray();
        return eligibleCharacters.Distinct().Count() == eligibleCharacters.Length;
    }
}