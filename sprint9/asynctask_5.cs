using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class CalcAsync : Calc
{
    public static async void PrintSpecificSeqElementsAsync(int[] n)
    {
        List<int> list = new List<int>();
        Task t = null;

        for (int i = 0; i < n.Length; i++)  
        {
            if (n[i] > 0)
            {
                list.Add(n[i]);
            }
        }
        
        list = list.OrderBy(x => x).ToList();

        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] <= 0)
            {
                list.Add(n[i]);
            }    
        }
        
        for (int i = 0; i <list.Count; i++)
        {
            try 
            {
                t = Task.Run(() => Console.WriteLine($"Seq[{list[i]}] = {Seq(list[i])}"));
                await t;
            }
            catch (Exception)
            {
                Console.WriteLine($"Inner exception: {t.Exception?.InnerException?.Message}");
            }
        }
    }
}
