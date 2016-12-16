using System.Collections.Generic;

internal class School
{
    public Dictionary<int, List<string>> Roster { get; set; }

    public School()
    {
        Roster = new Dictionary<int, List<string>>();
    }
    
    public void Add(string student, int grade)
    {
        if (!Roster.ContainsKey(grade))
        {
            Roster[grade] = new List<string> { student };
        }
        else
        {
            Roster[grade].Add(student);
            Roster[grade].Sort();
        }
    }

    public List<string> Grade(int grade)
    {
        return Roster.ContainsKey(grade) ? Roster[grade] : new List<string>();
    }
}