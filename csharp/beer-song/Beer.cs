using System.Text;
public static class StringExtensions
{
    public static string FirstToUpper(this string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }
        return char.ToUpper(s[0]) + s.Substring(1);
    }
}

public class Beer
{
    public static string Sing(int start, int stop)
    {
        var verses = new StringBuilder();
        for (var i = start; i >= stop; i--)
        {
            verses.Append(Verse(i) + "\n");
        }
        return verses.ToString();
    }

    public static string AddPlural(int count)
    {
        return count != 1 ? "s" : "";
    }

    public static string Verse(int number)
    {
        var nextNumber = number == 0 ? 99 : number - 1;
        return $"{GenerateBottleCountString(number).FirstToUpper()} bottle{AddPlural(number)} of beer on the wall, {GenerateBottleCountString(number)} bottle{AddPlural(number)} of beer.\n{GeneratePassAroundString(number)}, {GenerateBottleCountString(nextNumber)} bottle{AddPlural(nextNumber)} of beer on the wall.\n";
    }

    private static string GeneratePassAroundString(int number)
    {
        return number == 0 ? GoToTheStoreAndBuySomeMore() : TakeBottleDownAndPassItAround(number);
    }

    private static string TakeBottleDownAndPassItAround(int number)
    {
        return $"Take {GenerateItOrOneString(number)} down and pass it around";
    }

    private static string GenerateItOrOneString(int number)
    {
        return number == 1 ? "it" : "one";
    }

    private static string GenerateBottleCountString(int i)
    {
        return i == 0 ? "no more" : i.ToString();
    }

    private static string GoToTheStoreAndBuySomeMore()
    {
        return "Go to the store and buy some more";
    }
}