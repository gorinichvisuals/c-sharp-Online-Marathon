using System.Collections.Generic;

class CalcAsync : Calc
{
    public static async void PrintStream(IAsyncEnumerable<(int, int)> stream)
    {
        await foreach(var (x, seqNumber) in stream)
        {
            Console.WriteLine($"Seq[{x}] = {seqNumber}");
        }
    }

    public static async IAsyncEnumerable<(int, int)> SeqStreamAsync(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            yield return (i, Seq(i));
        }
    }
}
