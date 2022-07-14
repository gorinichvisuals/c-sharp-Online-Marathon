using System;
using System.Linq;

public static double EvaluateSumOfElementsOddPositions(double[] inputData)
{
   var sumNumber = inputData.Where((x, index) => index % 2 != 0).Sum();
   return sumNumber;
}
