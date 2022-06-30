public class CalcProgram
{
    public delegate int CalcDelegate(int x, int y, char operation);
    public static int Calc(int x, int y, char oper)
    {
        int result = 0;
        if (y != 0)
        {
            switch (oper)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    result = x / y;
                    break;
            }
        }
        else
        {
            result = 0;
        }
        return result;
    }
    public CalcDelegate funcCalc = Calc;
}
