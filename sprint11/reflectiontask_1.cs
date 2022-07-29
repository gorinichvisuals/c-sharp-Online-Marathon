using System.Reflection;
using System.Collections.Generic;

class ReflectFields
{
    public static string Name;
    public static int MeasureX;
    public static int MeasureY;
    public static int MeasureZ;
    
    public static void OutputFields()
    {
        foreach (FieldInfo field in typeof(ReflectFields).GetFields())
        {
            Console.WriteLine($"{field.Name} ({TypeAlias.TypeSimplifyName(field.FieldType)}) = {field.GetValue(field)}");
        }
    }
}

class TypeAlias
{
    private static readonly Dictionary<Type, string?> _typeAlias = new Dictionary<Type, string?>
    {
        {typeof(int), "int"},
        {typeof(string), "string"}
    };

    public static string? TypeSimplifyName(Type type)
        => _typeAlias.TryGetValue(type, out var alias)
            ? alias
            : type.Name;
}
