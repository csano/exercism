using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using NUnit.Framework;
using NUnit.Framework.Constraints;

[TestFixture]
public class ScrabbleScoreTest
{
    [Test]
    public void Empty_word_scores_zero()
    {
        Assert.That(Scrabble.Score(""), Is.EqualTo(0));
    }

    [Test]
    public void Whitespace_scores_zero()
    {
        Assert.That(Scrabble.Score(@" \tword"), Is.EqualTo(0));
    }

    [Test]
    public void Null_scores_zero()
    {
        Assert.That(Scrabble.Score(null), Is.EqualTo(0));
    }

    [Test]
    public void Scores_very_short_word()
    {
        Assert.That(Scrabble.Score("a"), Is.EqualTo(1));
    }

    [Test]
    public void Scores_other_very_short_word()
    {
        Assert.That(Scrabble.Score("f"), Is.EqualTo(4));
    }

    [Test]
    public void Simple_word_scores_the_number_of_letters()
    {
        Assert.That(Scrabble.Score("street"), Is.EqualTo(6));
    }

    [Test]
    public void Complicated_word_scores_more()
    {
        Assert.That(Scrabble.Score("quirky"), Is.EqualTo(22));
    }

    [Test]
    public void Scores_are_case_insensitive()
    {
        Assert.That(Scrabble.Score("OXYPHENBUTAZONE"), Is.EqualTo(41));
    }
}

public class Scrabble
{
    private static readonly Dictionary<string, int> ScoreDictionary = new Dictionary<string, int>
    {
        {"A", 1},
        {"E", 1},
        {"I", 1},
        {"O", 1},
        {"U", 1},
        {"L", 1},
        {"N", 1},
        {"R", 1},
        {"S", 1},
        {"T", 1},
        {"D", 2},
        {"G", 2},
        {"B", 3},
        {"C", 3},
        {"M", 3},
        {"P", 3},
        {"F", 4},
        {"H", 4},
        {"V", 4},
        {"W", 4},
        {"Y", 4},
        {"K", 5},
        {"J", 8},
        {"X", 8},
        {"Q", 10},
        {"Z", 10}
    };

    public static int Score(string word)
    {
        return string.IsNullOrEmpty(word?.Trim()) || word.StartsWith(" ") ? 0 : word.ToCharArray().Sum(letter => ScoreDictionary[letter.ToString().ToUpper()]);
    }
}