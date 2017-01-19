using System.Collections.Generic;

public class Tryptophan : AminoAcid
{
    public override HashSet<string> Codons => new HashSet<string> { "UGG" };
}