using System;

public class MyAccessModifiers
{
    private int birthYear;
    protected string personalInfo;
    private protected string IdNumber;
    int currentYear = DateTime.Now.Year;
    public static byte averageMiddleAge = 50;
    internal string Name { get; set; }
    public string NickName { get; internal set; }

    public MyAccessModifiers(int birthYear, string personalInfo, string idNumber)
    {
        this.birthYear = birthYear;
        this.personalInfo = personalInfo;
        this.IdNumber = idNumber;
    }

    public int Age 
    { 
        get { return currentYear - birthYear; }
    }

    protected internal void HasLivedHalfOfLife()
    {
        //Some code..
    }
    
    public static bool operator ==(MyAccessModifiers a, MyAccessModifiers b) 
    {
       // Console.WriteLine(a.Name);
        return (a.Name == b.Name && a.Age == b.Age && a.personalInfo == b.personalInfo);
    }
    
    public static bool operator !=(MyAccessModifiers a, MyAccessModifiers b)
    {
       // Console.WriteLine(a.Name);
       // Console.WriteLine(b.Name);
       // Console.WriteLine(a.Age);
       // Console.WriteLine(b.Age);
       // Console.WriteLine(a.personalInfo);
       // Console.WriteLine(b.personalInfo);
       // Console.WriteLine(a.IdNumber);
       // Console.WriteLine(b.IdNumber);
        return (a.Name != b.Name || a.Age != b.Age || a.personalInfo != b.personalInfo || a.IdNumber != b.IdNumber);   
    }
    
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    
    public override bool Equals(object obj)
    {
        return ReferenceEquals(this, obj) || obj is MyAccessModifiers other && other == this;
    }
}
