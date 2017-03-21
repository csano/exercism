using System.Collections.Generic;

public class Leucine : AminoAcid
{
    public override HashSet<string> Codons => new HashSet<string> { "UUA", "UUG" };
}