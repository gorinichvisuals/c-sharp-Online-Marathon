using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

class MyTasks
{
    public static void Tasks()
    {
        int[] sequence_array = new int[10];

        Task[] tasks1 = new Task[2]
        {
            new Task(() =>
            {
                Console.WriteLine("Calculated!");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("Bye!");
            }),
            new Task (() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    sequence_array[i] = i * i;
                    Console.WriteLine(sequence_array[i]);
                }
                Console.WriteLine("Bye!");
                Console.WriteLine("Main done!");
            })
        };
        foreach (var task in tasks1)
        {
            task.Start();
            task.Wait();
        }
    }
}
