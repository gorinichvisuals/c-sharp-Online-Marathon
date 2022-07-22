using System.Threading.Tasks;

static class CalcAsync 
{
    public static TaskStatus status;

    public static async Task TaskPrintSeqAsync(int n)
    {
        await Task.Run(() => Console.WriteLine($"Seq[{n}] = {Calc.Seq(n)}"));
    }

    public static void PrintStatusIfChanged(this Task t, ref TaskStatus status)
    {
        if (t.Status != status)
        {
            Console.WriteLine(t.Status.ToString());
        }

        status = t.Status;
    }

    public static void TrackStatus(this Task t)
    {
        TaskStatus status = TaskStatus.Running;
        
        while (t.IsCompleted == false)
        {
            t.PrintStatusIfChanged(ref status);
        }
    }
}
