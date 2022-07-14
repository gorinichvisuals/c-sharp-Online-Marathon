using System.Linq;

public static int ProductWithCondition(List<int> list, Func<int, bool> function)
{
    var resultWhere = list.Where(function).ToList();

    if (list.Count == 0 || resultWhere.Count == 0)
    {
        return 1;
    }

    var result = resultWhere.Aggregate((x, y) => x * y);

    return result;
}
