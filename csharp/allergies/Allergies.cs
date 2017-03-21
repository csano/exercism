using System;
using System.Collections.Generic;

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
        var list = new List<string>();
        foreach(var value in Enum.GetValues(typeof(Allergen)))
        {
            var allergen = (Allergen) value;

            if (IsAllergicTo(allergen))
            {
                list.Add(allergen.ToString().ToLower());
            }
        }
        return list;
    }
}