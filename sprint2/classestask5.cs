class Acinonychini 
{
    internal string name;
    internal string description;
    internal string subspecies;

    public Acinonychini(string name, string description, string subspecies)
    {
        this.name = name;
        this.description = description;
        this.subspecies = subspecies;
    }
}

sealed class Acinonyx : Acinonychini
{
    public Acinonyx(string name, string description, string subspecies) : base(name, description, subspecies)   
    {
        this.name = name;
        this.description = description;
        this.subspecies = subspecies;
    }
}



class Puma : Acinonychini 
{
    private string classification;

    public Puma(string name, string description, string subspecies, string classification) : base (name, description, subspecies)
    {
        this.name = name;
        this.description = description;
        this.subspecies = subspecies;
        this.classification = classification;
    }
}
