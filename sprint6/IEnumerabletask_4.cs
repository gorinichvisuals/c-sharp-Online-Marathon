using System.Collections.Generic;
class ShowPowerRange 
{
    public static IEnumerable<int> PowerRanger(int degree, int start, int finish)
    {
        if (start > finish || start < 0 || finish < 0) 
        {
            yield return 0;
        }
        else if (degree == 0 && start >= 1) 
        {
            yield return 1;
        }
        else
        {
            for (int i = 0; i <= finish; i++)
            {
                double numberToPow = Math.Pow(i, degree);

                if (start <= numberToPow && numberToPow <= finish)
                {
                    yield return (int)numberToPow;
                }
            }
        }
    }
}
