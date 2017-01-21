using System;
using System.Collections.Generic;

public class ProteinTranslation
{
    private static readonly AminoAcidFactory AminoAcidFactory = new AminoAcidFactory();

    public static IEnumerable<string> Translate(string pattern)
    {
        var list = new List<string>();
        foreach (var chunk in Chunkify(pattern, 3))
        {
            var aminoAcid = AminoAcidFactory.Find(chunk);

            if (aminoAcid == null)
            {
                throw new Exception();
            }

            if (aminoAcid is Stop)
            {
                break;
            }

            list.Add(aminoAcid.ToString());
        }
        return list;
    }

    public static IEnumerable<string> Chunkify(string pattern, int chunkSize)
    {
        for (var i = 0; i < pattern.Length; i += chunkSize)
        {
            yield return pattern.Substring(i, chunkSize);
        }
    }
}