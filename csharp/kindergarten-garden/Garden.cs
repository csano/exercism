using System.Collections.Generic;
using System.Linq;

public class Garden
{
    private readonly List<string> names;
    private readonly string pattern;

    private static readonly Dictionary<char, Plant> PlantMapping = new Dictionary<char, Plant>
    {
        { 'C', Plant.Clover },
        { 'G', Plant.Grass },
        { 'R', Plant.Radishes },
        { 'V', Plant.Violets },
    };

    private static readonly List<string> Students = new List<string>
    {
        "Alice",
        "Bob",
        "Charlie",
        "David",
        "Eve",
        "Fred",
        "Ginny",
        "Harriet",
        "Ileana",
        "Joseph",
        "Kincaid",
        "Larry"
    };

    public Garden(IEnumerable<string> names, string pattern)
    {
        this.names = new List<string>(names);
        this.names.Sort();
        this.pattern = pattern;
    }

    public Plant[] GetPlantsForStudent(string student)
    {
        var index = names.IndexOf(student);
        var plants = new List<Plant>();
        if (index >= 0)
        {
            foreach (var line in pattern.Split('\n'))
            {
                plants.AddRange(line.Substring(index * 2, 2).ToCharArray().Select(c => PlantMapping[c]));
            }
        }
        return plants.ToArray();
    }

    public static Garden DefaultGarden(string garden)
    {
        return new Garden(Students.ToArray(), garden);
    }
}