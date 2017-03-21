using System;
using System.Collections.Generic;
using System.Linq;

public class Proverb
{
    private static readonly List<string> Items = new List<string>
    {
       "nail",
       "shoe",
       "horse",
       "rider", 
       "message",
       "battle",
       "kingdom"
    };

    private const int ProverbLineCount = 7;

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
        return string.Join("\n", Enumerable.Range(1, ProverbLineCount).Select(Line));
    }

    public static string Line(int lineNumber)
    {
        return lineNumber != ProverbLineCount ? BuildForWantLine(lineNumber) : GetLastLine();
    }
}