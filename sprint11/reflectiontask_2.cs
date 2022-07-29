using System.Reflection;

class ReflectMethod
{
    public class Methods
    {
        public static void Hello(string parameter)
        {
            Console.WriteLine("Hello:parameter={0}", parameter);
        }
        public static void Welcome(string parameter)
        {
            Console.WriteLine("Welcome:parameter={0}", parameter);
        }
        public static void Bye(string parameter)
        {
            Console.WriteLine("Bye:parameter={0}", parameter);
        }
    }

    public static void InvokeMethod(string[] array)
    {
        foreach (var method in typeof(Methods).GetMethods())
        {
            for(int i = 0; i < array.Length; i++)
            {
                try
                {
                    method.Invoke(method, new object[] {array[i] });
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
