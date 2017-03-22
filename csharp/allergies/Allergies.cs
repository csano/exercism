using System;
using System.Collections.Generic;
using System.Linq;

public class Allergies
{
    private readonly int allergyIndex;

    private enum Allergen
    {
        Eggs = 1,
        Peanuts = 2,
        Shellfish = 4,
        Strawberries = 8,
        Tomatoes = 16,
        Chocolate = 32,
        Pollen = 64,
        Cats = 128 
    }

    public Allergies(int allergyIndex)
    {
        this.allergyIndex = allergyIndex;
    }

    public bool AllergicTo(string item)
    {
        Allergen allergen;
        return Enum.TryParse(item, true, out allergen) && IsAllergicTo(allergen);
    }

    private bool IsAllergicTo(Allergen allergen)
    {
        return ((int) allergen & allergyIndex) != 0;
    }

    public List<string> List()
    {
        return 
            Enum.GetValues(typeof(Allergen))
                .Cast<Allergen>()
                .Where(IsAllergicTo)
                .Select(x => x.ToString().ToLower())
                .ToList();
    }
}