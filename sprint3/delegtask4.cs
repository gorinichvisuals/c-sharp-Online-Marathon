using System.Collections.Generic;
using System.Linq;

public static class IListExtensions
{
    public static void IncreaseWith(this IList<int> numbers, int number)
    {
        for (int i = 0; i < numbers.Count; i++) 
        {
            numbers[i] += number;
        }
    }
}

public static class IEnumerableExtensions 
{
    public static string ToString<T>(this IEnumerable<int> numbers)
    {
        return $"[{string.Join(", ", numbers.ToArray())}]";
    }
}
