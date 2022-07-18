using System.Threading;

class ParallelUtils <T, TR>
{
    private Func<T, T, TR> func;
    private T operand1;
    private T operand2;
    public TR Result { get; set; }

    public ParallelUtils(Func<T, T, TR> func, T operand1, T operand2)
    {
        this.func = func;
        this.operand1 = operand1;
        this.operand2 = operand2;
    }

    public void StartEvaluation()
    {
        Thread newThread = new Thread(() => Result = func(operand1, operand2));
        newThread.Start();
    }


    public void Evaluate()
    {
        Thread newThread = new Thread(() => Result = func(operand1, operand2));
        newThread.Start();
        newThread.Join();
    }
}
