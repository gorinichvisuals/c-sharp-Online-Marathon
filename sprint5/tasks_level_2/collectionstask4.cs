using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

class MyUtils
{
    public static bool ListDictionaryCompare(List<string> list, Dictionary<string, string> dict)
    {
        var result1 = list.Except(dict.Values).ToList();
        var result2 = dict.Values.ToList().Except(list);
        return !result1.Any() && !result2.Any();
    }
}
