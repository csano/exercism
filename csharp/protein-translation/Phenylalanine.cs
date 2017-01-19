using System.Collections.Generic;

public class Phenylalanine : AminoAcid
{
    public override HashSet<string> Codons => new HashSet<string> { "UUU", "UUC" };
}