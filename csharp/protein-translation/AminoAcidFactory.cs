using System;
using System.Collections.Generic;
using System.Linq;

public class AminoAcidFactory
{
    private readonly IEnumerable<AminoAcid> AminoAcids;

    public AminoAcidFactory()
    {
        AminoAcids = 
            GetType()
                .Assembly
                .GetTypes()
                .Where(t => t.IsSubclassOf(typeof(AminoAcid)) && !t.IsAbstract)
                .Select(x => (AminoAcid) Activator.CreateInstance(x));
    }

    public AminoAcid Find(string codon)
    {
        return AminoAcids.FirstOrDefault(x => x.Codons.Contains(codon));
    }
}