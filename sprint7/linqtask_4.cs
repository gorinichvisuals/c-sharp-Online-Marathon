using System.Linq;

public static string GetWord(string input, string seed)
{
    string[] word = input.Split(' ');
    var longestWord = word.Aggregate((x, y) => y.ToString().Length > x.ToString().Length ? y : x).ToString();

    if (longestWord.Length < seed.Length)
    {
        longestWord = seed;
    }
    
    var query = longestWord.SkipWhile(w => w != 'a');
    longestWord = String.Empty;

    foreach (char w in query)
    {
        longestWord += w.ToString();
    }
    
    return longestWord;
}
