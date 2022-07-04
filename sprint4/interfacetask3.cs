public enum ColourEnum 
{
    Red,
    Green,
    Blue
}

public interface IColoured
{
    public ColourEnum Colour { get { return ColourEnum.Red; } }
}

public interface IDocument 
{
    public static string defaultText = "Lorem ipsum";

    public int Pages { get; set; }

    public String Name { get; set; }

    public void AddPages(in int x)
    {
        this.Pages += x;  
    }

    public void Rename(string name)
    {
        this.Name = name;
    }
}

public class ColouredDocument : IColoured, IDocument
{
    public String Name { get; set; }
    public int Pages { get; set; }
    public ColourEnum Colour { set; get; }

    public ColouredDocument(ColourEnum colour)
    {
        Colour = colour;
    }
    public ColouredDocument()
    {
        
    }
}

public class Example
{
    public static void Do() 
    {
        IDocument doc1 = new ColouredDocument();
        doc1.Name = "Document1";
        Console.WriteLine(doc1.Name);
        doc1.Rename("Document2");
        Console.WriteLine(doc1.Name);
    }
}
