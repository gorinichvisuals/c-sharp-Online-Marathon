using System.Linq;
using System.Collections.Generic;

public static Lookup<string, string> CreateNotebook(Dictionary<string, string> phonesToNames)
{
    var newLookup = phonesToNames.ToLookup(names => names.Value ?? String.Empty, phones => phones.Key);

    return (Lookup<string, string>)newLookup;
}
