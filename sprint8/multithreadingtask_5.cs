using System.Threading;

class MyThreads
{
    public static Mutex mutex = new Mutex();
    public static int n;
    public static int m;

    public Thread Thread1 = new Thread(
    () =>
    {
        mutex.WaitOne();

        for (int i = 0; i < 5; i++, n++)
        {
            Console.WriteLine("Thread1 n = " + n);
            ThreadsDemo.ExtraEvaluation(i);
        }

        mutex.ReleaseMutex();

        Thread.Yield();

        mutex.WaitOne();
        for (int i = 0; i < 5; i++, m++)
        {
            Console.WriteLine("Thread1 m = " + m);
        }
        Console.WriteLine("Thread1 success!");

        mutex.ReleaseMutex();
    });

    public Thread Thread2 = new Thread(
    () =>
    {
        mutex.WaitOne();

        for (int i = 0; i < 5; i++, m++)
        {
            Console.WriteLine("Thread2 m = " + m);
        }

        Thread.Yield();

        for (int i = 0; i < 5; i++, n++)
        {
            Console.WriteLine("Thread2 n = " + n);
        }
        Console.WriteLine("Thread2 success!");

        mutex.ReleaseMutex();
    });
}
