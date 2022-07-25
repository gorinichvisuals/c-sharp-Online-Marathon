public interface IFlyable
{
    void Fly();
}

public interface IEating
{
    void Eat();
}

public interface IMoving
{
    void Move();
}

public interface IBasking
{
    void Bask();
}

public interface IKryaking
{
    void Krya();
}

class Cat : IMoving, IEating, IBasking
{
    public string Name { get; set; }
    
    public void Move()
    {
        Console.WriteLine("I can jump!");
    }
    
    public void Eat()
    {
        Console.WriteLine("Oh! My milk!");
    }
    
    public void Bask()
    {
        Console.WriteLine("Mrrr-Mrrr-Mrrr...");
    }
}

class Bird : IFlyable, IEating, IMoving
{
    public string Name { get; set; }
    
    public void Fly()
    {
        Console.WriteLine("I believe, I can fly");
    }
    
    public void Eat()
    {
        Console.WriteLine("Oh! My corn!");
    }
    
    public void Move()
    {
        Console.WriteLine("I can jump!");
    }
}

class Parrot : Bird, IKryaking, IBasking
{
    public void Eat()
    {
        Console.WriteLine("Oh! My seeds and fruits!");
    }
    
    public void Krya()
    {
        Console.WriteLine("Krya-Krya-Krya...");
    }
    
    public void Bask()
    {
        Console.WriteLine("Chuh-Chuh-Chuh...");
    }
}

class Duck : Bird, IKryaking
{
    public void Move()
    {
        Console.WriteLine("I can swimm!");
    }
    
    public void Krya()
    {
        Console.WriteLine("Krya-Krya!");
    }
}
