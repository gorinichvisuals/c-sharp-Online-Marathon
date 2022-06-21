using System.Collections.Generic;
using System.Linq;
static class AnagramSolver
{
    public static bool IsAnagram(string s1, string s2)
    {
        var anagrams = Permutations(s1).ToList();

        foreach (var anagram in anagrams)
        {
            var c = new string(anagram.ToArray());
            bool b = s2.Contains(c);

            if (b)
            {
                return true;
            }
        }

        return false;
    }

    public static IEnumerable<IEnumerable<T>> Permutations<T>(IEnumerable<T> items)
    {
        foreach (var item in items)
        {
            var s1 = new T[] { item };
            var s2 = items.Except(s1).ToList();
            var subLists = Permutations(s2);

            if (subLists.Any())
            {
                foreach (var subList in subLists)
                {
                    yield return s1.Concat(subList);
                }
            }
            else
            {
                yield return s1;
            }
        }
    }
}
class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine(AnagramSolver.IsAnagram("nod", "done"));
        Console.WriteLine(AnagramSolver.IsAnagram("bag", "grab"));
        Console.WriteLine(AnagramSolver.IsAnagram("car", "race"));
    }
}
