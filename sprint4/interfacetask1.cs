public interface ISwimmable 
{
    void Swim() => Console.WriteLine("I can swim!");    
}

interface IFlyable 
{
    public int MaxHeight { get { return 0; } }

    void Fly() => Console.WriteLine($"I can fly at {MaxHeight} meters height!");    
}

interface IRunnable 
{
    public int MaxSpeed { get { return 0; } }

    void Run() => Console.WriteLine($"I can run up to {MaxSpeed} kilometers per hour!");
}

interface IAnimal 
{
    public int LifeDuration { get { return 0; } }

    void Voice() => Console.WriteLine("No voice!");
    void ShowInfo() => Console.WriteLine($"I am a {GetType()} and I live approximately {LifeDuration} years.");
}

class Cat : IAnimal, IRunnable 
{
    public int LifeDuration { get; set; }
    public int MaxSpeed { get; set; }

    public void Voice() => Console.WriteLine("Meow!");
    public void ShowInfo() => Console.WriteLine($"I am a {this.GetType()} and I live approximately {this.LifeDuration} years.");
    public void Run() => Console.WriteLine($"I can run up to {this.MaxSpeed} kilometers per hour!");
}

class Eagle : IAnimal, IFlyable 
{
    public int LifeDuration { get; set; }
    public int MaxHeight { get; set; }

    public void Voice() => Console.WriteLine("No voice!");
    public void Fly() => Console.WriteLine($"I can fly at {this.MaxHeight} meters height!");
    public void ShowInfo() => Console.WriteLine($"I am a {this.GetType()} and I live approximately {this.LifeDuration} years.");
}

class Shark : IAnimal, ISwimmable  
{
    public int LifeDuration { get; set; }

    public void Voice() => Console.WriteLine("No voice!");
    public void Swim() => Console.WriteLine("I can swim!");
    public void ShowInfo() => Console.WriteLine($"I am a {this.GetType()} and I live approximately {this.LifeDuration} years.");
}
