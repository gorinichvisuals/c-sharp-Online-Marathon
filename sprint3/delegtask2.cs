public static class StringExtensions 
{
    public static int WordCount(this string stringWord)
    {   
        var count = stringWord.Split(new char[] { ' ', '.', '?', '!', '-', ';', ':', ',' },
                            StringSplitOptions.RemoveEmptyEntries).Length;

        return count;
    }
}
