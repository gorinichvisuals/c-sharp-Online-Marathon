class MyProgram 
{
    public void SearchKeys(Dictionary<string, string> persons)
    {
        foreach (var keys in persons.Keys)
        {
            Console.WriteLine(keys);
        }
    }

    public void SearchValues(Dictionary<string, string> persons)
    {
        foreach (var values in persons.Values)
        {
            Console.WriteLine(values);
        }
    }
    public static void SearchAdmin(Dictionary<string, string> persons)
    {
        var admin = persons.Where(x => x.Value == "Admin");

        foreach(var person in admin)
        {
            Console.WriteLine(person.Key + " " + person.Value);
        }        
    }
}
