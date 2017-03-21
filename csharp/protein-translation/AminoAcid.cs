using System.Collections.Generic;

public abstract class AminoAcid
{
    public abstract HashSet<string> Codons { get; }
    public override string ToString()
    {
        return GetType().Name;
    } 
}