class Fraction 
{
    private readonly int numerator;
    private readonly int denominator;
 
    public Fraction(int numerator, int denominator)
    {
        if (numerator < 0 && denominator < 0)
        {
            this.numerator = -numerator;
            this.denominator = -denominator;
        }
        else if (denominator < 0)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        else 
        {        
            this.numerator = numerator;
            this.denominator = denominator;
        }
        
        Simplify(ref this.numerator, ref this.denominator);
 
        if (numerator == 0)
        {
            throw new DivideByZeroException();
        }
    }
 
    public static Fraction operator +(Fraction a)
    {
        return new Fraction(a.numerator, a.denominator);
    }
    
    public static Fraction operator -(Fraction a)
    {
        return new Fraction(-a.numerator, a.denominator);
    }
 
    public static Fraction operator +(Fraction a, Fraction b)
    {
        int _num = a.numerator * b.denominator + b.numerator * a.denominator;
        int _den = a.denominator * b.denominator;
        Simplify(ref _num, ref _den);
        //return result;
        return new Fraction(_num, _den);
    }
 
    public static Fraction operator -(Fraction a, Fraction b)
    {
        int _num = a.numerator * b.denominator - b.numerator * a.denominator;
        int _den = a.denominator * b.denominator;
        Simplify(ref _num, ref _den);
        return new Fraction(_num, _den);
    }
 
    public static Fraction operator *(Fraction a, Fraction b)
    {
        int _num = a.numerator * b.numerator;
        int _den = a.denominator * b.denominator;
        Simplify(ref _num, ref _den);
        return new Fraction(_num, _den);
    }
 
    public static Fraction operator /(Fraction a, Fraction b)
    {
        int _num = a.numerator * b.denominator;
        int _den = a.denominator * b.numerator;
        Simplify(ref _num, ref _den);
        return new Fraction(_num, _den);
    }
 
    private static int GetGreatCommonDiv(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
 
    public static void Simplify(ref int num, ref int den)
    {
        int cmnfactor = GetGreatCommonDiv(num, den);
        num = num / cmnfactor;
        den = den / cmnfactor;
        //new Fraction(num, den);
    }
 
    public static Fraction operator !(Fraction a)
    {  
        //Simplify(ref a.denominator, ref a.numerator);
        return new Fraction(a.denominator, a.numerator);
    }
 
    public static bool operator ==(Fraction a, Fraction b)
    {
        return (a.numerator == b.numerator && a.denominator == b.denominator);
    }
    public static bool operator !=(Fraction a, Fraction b)
    {
        return (a.numerator != b.numerator || a.denominator != b.denominator);  
    }
    public override string ToString()
    {
        int denom = denominator < 0 ? -denominator : denominator;
        int numer = denominator < 0 ? -numerator : numerator;
        
        return numer + " / " + denom;
    }
 
    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }
 
    public override int GetHashCode()
    {
        return base.GetHashCode();  
    }
}
