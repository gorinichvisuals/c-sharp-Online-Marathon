using System.Reflection;

class ReflectorAssembly
{
    public class LargeBox
    {
        public static void UnPackingBox(string size)
        {
            Console.WriteLine("I am unpacking {0} box.", size);
        }

        public static void InBox(string size)
        {
            Console.WriteLine("I am in {0} box.", size);
        }
    }

    public class Box
    {
        public static void UnPackingBox(string size)
        {
            Console.WriteLine("I am unpacking {0} box.", size);
        }

        public static void InBox(string size)
        {
            Console.WriteLine("I am in {0} box.", size);
        }
    }

    public class SmallBox
    {
        public static void UnPackingBox(string size)
        {
            Console.WriteLine("I am unpacking {0} box.", size);
        }

        public static void InBox(string size)
        {
            Console.WriteLine("I am in {0} box.", size);
        }
    }

    public interface ILookingForBox
    {
        public static void LookForBox(string param) { }
    }

    public interface IPackingBox
    {
        public static void PackBox(string param) { }
    }

    public static void WriteAssemblies()
    {
        string[] args = new string[3] { "large", "middle", "small" };
        Assembly assembly = Assembly.GetExecutingAssembly();

        foreach (var t in assembly.GetTypes())
        {
            if(t.Name != "Task" && t.Name != "Reflector")
            { 
                if (t.GetTypeInfo().IsClass)
                {
                    Console.WriteLine("Class: " + t.Name);
                }
                else if (t.GetTypeInfo().IsInterface)
                {
                    Console.WriteLine("Interface: " + t.Name);
                }
                
                foreach(var method in t.GetMethods(
                    BindingFlags.Public | BindingFlags.DeclaredOnly | 
                    BindingFlags.NonPublic | BindingFlags.Static))
                {
                    Console.WriteLine("Method: " + method.Name);

                    switch (t.Name)
                    {
                        case "LargeBox":
                            method.Invoke(method, new object[] { args[0] });
                            break;

                        case "Box":
                            method.Invoke(method, new object[] { args[1] });
                            break;

                        case "SmallBox":
                            method.Invoke(method, new object[] { args[2] });
                            break;
                    }
                }
            }
        }
    }
}
