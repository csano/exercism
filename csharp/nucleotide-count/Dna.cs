using System.Collections.Generic;

public class Dna
{
    public Dictionary<char, int> NucleotideCounts { get; }

    public Dna(string nucleotides)
    {
        NucleotideCounts = new Dictionary<char, int> { { 'A', 0 }, { 'T', 0 }, { 'C', 0 }, { 'G', 0 } };
        CalculateNucleotideCounts(nucleotides);
    }

    public int Count(char nucleotide)
    {
        if (!NucleotideCounts.ContainsKey(nucleotide))
        {
            throw new InvalidNucleotideException();
        }
        return NucleotideCounts[nucleotide];
    }

    private void CalculateNucleotideCounts(string nucleotides)
    {
        foreach (var nucleotide in nucleotides)
        {
            NucleotideCounts[nucleotide]++;
        }
    }
}