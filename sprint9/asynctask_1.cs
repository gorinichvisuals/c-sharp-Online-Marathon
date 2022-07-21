using System.Threading.Tasks;

class CalcAsync : Calc
{
    public static async void PrintSeqAsync(int n)
    {
        await Task.Run(() => Console.WriteLine($"Seq[{n}] = {Seq(n)}"));
    }
}
