using System.Collections.Generic;

public class Serine : AminoAcid
{
    public override HashSet<string> Codons => new HashSet<string> { "UCU", "UCC", "UCA", "UCG" };
}