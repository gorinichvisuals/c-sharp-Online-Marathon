using System.Collections.Generic;

public interface IShape 
{
    public double Area()
    {
        return 0;
    }
}

public class Rectangle : IShape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public double Area()
    {
        return Length*Width;
    }
}

public class Trapezoid : IShape 
{
    public double Length1 { get; set; }
    public double Length2 { get; set; }
    public double Width { get; set; }

    public double Area()
    {
        return ((Length1 + Length2)/2)*Width;
    }
}

class Room<T> : ICloneable, IComparable where T : IShape
{
    public double Height { get; set; }
    public T Floor { get; set; }

    public Room()
    {

    }

    public Room(double height, T floor)
    {
        this.Height = height;
        this.Floor = floor;
    }

    public double Volume()
    {
        return Floor.Area() * Height;
    }

    public object Clone()
    {
        T newObject = (T)Activator.CreateInstance(this.Floor.GetType());
        foreach (var originalProp in this.Floor.GetType().GetProperties())
        {
            originalProp.SetValue(newObject, originalProp.GetValue(this.Floor));
        }
        return new Room<T>
        {
            Floor= newObject,
            Height = this.Height
        };
    }

    public int CompareTo(object obj)
    {
        Room<T> room = obj as Room<T>;
        return this.Floor.Area().CompareTo(room.Floor.Area());
    }
}

class RoomComparerByVolume<T> : IComparer<Room<T>> where T: IShape
{
    public int Compare(Room<T> obj1, Room<T> obj2)
    {
        if (obj1.Volume() > obj2.Volume())
            return 1;
        else if (obj1.Volume() < obj2.Volume())
            return -1;
        else
            return 0;
    } 
}
