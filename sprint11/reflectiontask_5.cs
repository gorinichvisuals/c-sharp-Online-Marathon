using System.Reflection;
using System.Linq;

class ReflectFullClass
{
    public static void WriteAllInClass(Type type)
    {
        Console.WriteLine("Hello, " + type.Name + "!");

        Console.WriteLine("There are " + type.GetFields().Length + " fields in " + type.Name + ": ");
        foreach (var fields in type.GetFields())
        {
            Console.Write(fields.Name + ", ");
        }

        Console.WriteLine();
        Console.WriteLine("There are " + type.GetProperties().Length + " properties in " + type.Name + ": ");
        foreach (var properties in type.GetProperties())
        {
            Console.Write(properties.Name + ", ");
        }

        Console.WriteLine();
        Console.WriteLine("There are " + type.GetMethods(BindingFlags.Instance | BindingFlags.Public | 
            BindingFlags.DeclaredOnly).Where(x => !x.IsSpecialName).Count() + " methods in " + type.Name + ": ");
        foreach (var methods in type.GetMethods(
            BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance ).Where(x => !x.IsSpecialName))
        {
            Console.Write(methods.Name + ", ");
        }

        Console.WriteLine();
        Console.WriteLine("There are " + type.GetNestedTypes().Count() + " interfaces in " + type.Name + ": ");
        foreach (var interfaces in type.GetNestedTypes())
        {
            Console.Write(interfaces.Name + ", ");
        }
    }
}
