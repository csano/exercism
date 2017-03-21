using System;

internal class Robot
{
    private static readonly Random Random = new Random(DateTime.Now.Millisecond);

    public Robot()
    {
        Reset();
    }

    private static string GenerateNumbers()
    {
        return Random.Next(0, 999).ToString("D3");
    }

    private static string GenerateLetters()
    {
        var output = "";
        for (var i = 0; i < 2; i++)
        {
            output += (char)Random.Next('A', 'Z');
        }
        return output;
    }

    private void SetName()
    {
        Name = $"{GenerateLetters()}{GenerateNumbers()}";
    }

    public void Reset()
    {
        SetName();
    }

    public string Name { get; private set; }
}