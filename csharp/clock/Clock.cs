using System;

public class Clock : IEquatable<Clock>
{
    private readonly int minutes;

    public Clock(int hour)
    {
        minutes += hour * 60;
    }

    public Clock(int hour, int minutes) : this(hour)
    {
        this.minutes += minutes;
    }

    public Clock Subtract(int minutes)
    {
        return new Clock(0, this.minutes - minutes);
    }

    public override string ToString()
    {
        var totalHours = minutes / 60 % 24;
        var totalMinutes = minutes % 60;

        if (totalMinutes < 0)
        {
            totalHours = 23;
            totalMinutes = 60 + totalMinutes;
        }

        if (totalHours < 0)
        {
            totalHours = 24 + totalHours;
        }

        return $"{totalHours:d2}:{totalMinutes:d2}";
    }

    public Clock Add(int minutes)
    {
        return new Clock(0, this.minutes + minutes);
    }

    public bool Equals(Clock other)
    {
        return ToString().Equals(other?.ToString());
    }
}