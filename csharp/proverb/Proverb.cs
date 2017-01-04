using System.Collections.Generic;
using System.Text;

public class Proverb
{
    private static readonly List<string> Items = new List<string>()
    {
       "nail",
       "shoe",
       "horse",
       "rider", 
       "message",
       "battle",
       "kingdom"
    };

    private static string BuildForWantLine(int line)
    {
        return $"For want of a {Items[line - 1]} the {Items[line]} was lost.";
    }

    private static string GetLastLine()
    {
        return "And all for the want of a horseshoe nail.";
    }
    
    public static string AllLines()
    {
        var output = new StringBuilder();
        for(var lineNumber = 1; lineNumber < 7; lineNumber++)
        {
            output.Append(BuildForWantLine(lineNumber) + "\n");
        }
        output.Append(GetLastLine());
        return output.ToString();
    }

    public static string Line(int lineNumber)
    {
        return lineNumber != 7 ? BuildForWantLine(lineNumber) : GetLastLine();
    }
}