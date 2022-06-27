abstract class Car 
{
    internal string mark;
    internal int prodYear;

    public Car(string mark, int prodYear)
    {
        this.mark = mark;
        this.prodYear = prodYear;
    }
    public void ShowInfo()
    {
        Console.Write($"Mark: {this.mark}" +
        $"Producted in {this.prodYear}");
    }
}

class SportCar : Car 
{
    private int maxSpeed;

    public SportCar (string mark, int prodYear, int maxSpeed) : base(mark, prodYear)
    {

        this.maxSpeed = maxSpeed;
    }
    public new void ShowInfo()
    {
        Console.Write($"Mark: {this.mark}" +
                      $"Producted in {this.prodYear}" +
                      $"Maximum speed is {this.maxSpeed}");
    }
}

class Lory : Car 
{
    private double loadCapacity;

    public Lory(string mark, int prodYear, double loadCapacity) : base(mark, prodYear)
    {
        this.loadCapacity = loadCapacity;
    }
    public new void ShowInfo()
    {
        Console.Write($"Mark: {this.mark}" +
                      $"Producted in {this.prodYear}" +
                      $"The load capacity is {this.loadCapacity}");
    }
}
