using System.Collections.Generic;

public class Tyrosine : AminoAcid
{
    public override HashSet<string> Codons => new HashSet<string> { "UAU", "UAC" };
}