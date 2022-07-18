using System.Collections.Generic;
using System.Threading;
using System.Linq;

class MainThreadProgram
{
    public static void Sum()
    {
        Console.WriteLine("Enter the 1st number: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the 2nd number: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the 3rd number: ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the 4th number: ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the 5th number: ");
        double e = Convert.ToDouble(Console.ReadLine());

        double sum = a + b + c + d + e;
        Console.WriteLine($"Sum is: {sum}");
    }

    public static void Product()
    {
        List<int> list = new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int product = list.Aggregate((x, y) => x * y);
        Thread.Sleep(10000);
        Console.WriteLine($"Product is: {product}");
    }

    public static (Thread, Thread)  Calculator()
    {
        Thread productThread = new Thread(Product);
        Thread sumThread = new Thread(Sum);
        productThread.Start();
        sumThread.Start();
        return (sumThread, productThread);
    }
}
