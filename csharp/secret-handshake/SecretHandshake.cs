using System.Collections.Generic;
using System.Linq;

public class SecretHandshake
{
    public static string[] Commands(int numberOfCommands)
    {
        var mappings = new Dictionary<int, string>
        {
            {0x1, "wink"},
            {0x2, "double blink"},
            {0x4, "close your eyes"},
            {0x8, "jump"},
        };

        var handshake = mappings.Where(x => (x.Key & numberOfCommands) != 0).Select(x => x.Value);

        return ((numberOfCommands & 10000) != 0 ? handshake.Reverse() : handshake).ToArray();
    }
}