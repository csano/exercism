using System.Collections.Generic;

public class Methionine : AminoAcid
{
    public override HashSet<string> Codons => new HashSet<string> { "AUG" };
}