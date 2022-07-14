using System.Linq;

public static double EvaluateAggregate(double[] inputData, Func<double, double, double> aggregate, Func<double, int, bool> predicate)
{
   var result = inputData.Where(predicate).Aggregate(aggregate);
    
    return result;
}
