using System.Threading;
using System.Threading.Tasks;
 
class MyProgram
{    
    public static void Counter(int number)
    {
        Task<int> thread = new Task<int>(() => Factorial(number));
        thread.Start();
        thread.Wait();
        
        int result = thread.Result;
        Console.WriteLine($"Factorial is: {result}");
        
        Task<int> thread1 = new Task<int>(() => Fibonachi(number));
        thread1.Start();
        thread1.Wait();
        
        int result1 = thread1.Result;
        Console.WriteLine($"Fibbonaci number is: {result1}");
    }
    
    private static int Factorial(int x)
    {
        if (x == 1)
        {
            return 1;
        }
        
        return x * Factorial(x - 1);
    }
    
    private static int Fibonachi(int x)
    {
        if (x == 0 || x == 1)
        {
            return x;
        }
        
        return Fibonachi(x - 1) + Fibonachi(x - 2);
    }
}
