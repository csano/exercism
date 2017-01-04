using System.Collections.Generic;

public class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, IList<string>> old)
    {
        var output = new Dictionary<string, int>();

        foreach(var score in old.Keys)
        {
            foreach (var letter in old[score])
            {
                output.Add(letter.ToLower(), score);
            }
        }

        return output;
    }
}