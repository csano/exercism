using System.Collections.Generic;

public class Stop : AminoAcid
{
    public override HashSet<string> Codons => new HashSet<string> { "UAA", "UAG", "UGA" };

    public override string ToString()
    {
        return string.Empty;
    }
}