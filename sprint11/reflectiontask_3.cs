using System.Reflection;

class ReflectProperties
{
    public class TestProperties
    {
        public string FirstName { get; set; }
        internal string LastName { get; set; }
        protected int Age { get; set; }
        private string PhoneNumber { get; set; }
    }

    public static void WriteProperties()
    {
        foreach (PropertyInfo property in typeof(TestProperties).GetProperties(
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            bool readable = property.CanRead;
            bool writable = property.CanWrite;

            Console.WriteLine("Property name: {0}", property.Name);
            Console.WriteLine("Property type: {0}", property.PropertyType);
            Console.WriteLine("Read-Write:    {0}", readable & writable);

            if (readable & writable)
            {
                MethodInfo getAccessor = property.GetMethod;
                Console.WriteLine("Accessibility: {0}",
                                  GetAccessibility(getAccessor));
            }
            
            Console.WriteLine();
        }
    }

    public static String GetAccessibility(MethodInfo accessor)
    {
        if (accessor.IsPublic)
            return "Public";
        else if (accessor.IsPrivate)
            return "Private";
        else if (accessor.IsFamily)
            return "Protected";
        else if (accessor.IsAssembly)
            return "Internal";
        else
            return "Protected Internal/Friend";
    }
}
