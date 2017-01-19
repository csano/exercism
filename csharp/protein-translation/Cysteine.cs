using System.Collections.Generic;

public class Cysteine : AminoAcid
{
    public override HashSet<string> Codons => new HashSet<string> { "UGU", "UGC" };
}