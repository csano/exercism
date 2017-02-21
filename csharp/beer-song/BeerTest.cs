using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class BeerTests
{
    [TestCase(8, ExpectedResult = "8 bottles of beer on the wall, 8 bottles of beer.\nTake one down and pass it around, 7 bottles of beer on the wall.\n")]
    [TestCase(2, ExpectedResult = "2 bottles of beer on the wall, 2 bottles of beer.\nTake one down and pass it around, 1 bottle of beer on the wall.\n")]
    [TestCase(1, ExpectedResult = "1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.\n")]
    [TestCase(0, ExpectedResult = "No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.\n")]
    public string Verse(int number)
    {
        return Beer.Verse(number);
    }
    
    [TestCase(8, 6, ExpectedResult = "8 bottles of beer on the wall, 8 bottles of beer.\nTake one down and pass it around, 7 bottles of beer on the wall.\n\n7 bottles of beer on the wall, 7 bottles of beer.\nTake one down and pass it around, 6 bottles of beer on the wall.\n\n6 bottles of beer on the wall, 6 bottles of beer.\nTake one down and pass it around, 5 bottles of beer on the wall.\n\n")]
    [TestCase(3, 0, ExpectedResult = "3 bottles of beer on the wall, 3 bottles of beer.\nTake one down and pass it around, 2 bottles of beer on the wall.\n\n2 bottles of beer on the wall, 2 bottles of beer.\nTake one down and pass it around, 1 bottle of beer on the wall.\n\n1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.\n\nNo more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.\n\n")]
    public string Sing(int start, int stop)
    {
        return Beer.Sing(start, stop);
    }
}

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
        return $"{GenerateBottleCountString(number).FirstToUpper()} bottle{AddPlural(number)} of beer on the wall, {GenerateBottleCountString(number)} bottle{AddPlural(number)} of beer.\n{GenerateFinalSentence(number)}, {GenerateBottleCountString(nextNumber)} bottle{AddPlural(nextNumber)} of beer on the wall.\n";
    }

    private static string GenerateFinalSentence(int number)
    {
        return number == 0 ? GoToTheStoreAndBuyMore() : TakeBottleDownAndPassItAround(number);
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

    private static string GoToTheStoreAndBuyMore()
    {
        return "Go to the store and buy some more";
    }
}