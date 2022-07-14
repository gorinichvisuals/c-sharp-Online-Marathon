using System.Linq;

public static string GetWord(string input, string seed)
{
    string[] strings = input.Split(' ');
    string longestWord = strings.Where(w => w.Length > seed.Length).OrderByDescending(w => w.Length).FirstOrDefault();

    if (longestWord == null)
    {
        longestWord = seed;
    }

    var word = longestWord.SkipWhile(w => w != 'a');
    
    longestWord = String.Empty;

    foreach (char w in word)
    {
        longestWord += w.ToString();
    }
    
    return longestWord;
}
