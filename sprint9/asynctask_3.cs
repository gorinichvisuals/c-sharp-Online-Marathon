using System.Collections.Generic;
using System.Threading.Tasks;

class CalcAsync : Calc
{
    public static async Task<int> SeqAsync(int n)
    {
        return await Task.Run(() => Seq(n));
    }

    public static async void PrintSeqElementsConsequentlyAsync(int quant)
    {
        for (int i = 1; i <= quant; i++)
        {
            Console.WriteLine($"Seq[{i}] = {(await SeqAsync(i)).ToString()}");
        }
    }

    public static async void PrintSeqElementsInParallelAsync(int quant)
    {
        var t = GetSeqAsyncTasks(quant);

        for (int i = 0; i < t.Length; i++)
        {
            Console.WriteLine($"Seq[{i + 1}] = {(await t[i]).ToString()}");
        }

        await Task.WhenAll(t);
    }

    public static Task<int>[]  GetSeqAsyncTasks(int quant)
    {
        var t = new List<Task<int>>();

        for (int i = 1; i <= quant; i++)
        {
            var iCopy = i;
            t.Add(Task.Run(() => SeqAsync(iCopy)));
        }

        return t.ToArray();
    }
}
