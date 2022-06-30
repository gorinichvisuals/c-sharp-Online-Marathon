using System.Collections.Generic;

class ListProgram
{
    public static List<int> ListWithPositive(List<int> elements)
    {
        var positiveElements = elements.FindAll(n => n <= 10 && n > 0 );
        
        return positiveElements;
    }
}
