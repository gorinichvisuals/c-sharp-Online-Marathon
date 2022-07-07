using System.Linq;
using System.Collections.Generic;

public static Dictionary<string, List<string>> ReverseNotebook(Dictionary<string, string> phonesToNames)
{
    return (Dictionary<string, List<string>>)phonesToNames.ToLookup(names => names.Value ?? String.Empty, phones => phones.Key).ToDictionary(x => x.Key, y => y.ToList());
}
