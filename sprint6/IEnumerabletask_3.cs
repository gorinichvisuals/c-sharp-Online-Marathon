using System;
using System.Collections.Generic;

class ShowPower
{
    public static IEnumerable<double> SuperPower(int number, int degree)
    {
        if (degree == 0)
        {
            yield return 1;
        }
        
        double result = 1;
        bool sing = true;
        
        if (degree < 0)
        {
            sing = false;
            degree = degree * -1;
        }

        for (int i = 1; i <= degree; i++)
        {
            if (sing)
            {
                result = result * number;
            }
            else
            {
                result /= number;
            }
            
            yield return result;
        }
    }
}
