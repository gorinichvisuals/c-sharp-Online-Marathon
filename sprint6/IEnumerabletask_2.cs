using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


public class Library : IEnumerable<Book>
{
    private MyEnumerator myEnumerator;
    public IEnumerable<Book> Books { get; }
    public Predicate<Book> Filter { get; set; }
    public Library(IEnumerable<Book> books)
    {
        Books = books;
        Filter = x => true;
    }
    public IEnumerator<Book> GetEnumerator()
    {
        myEnumerator = new MyEnumerator(Books, Filter);
        return myEnumerator;
    }
    IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
}

public sealed class MyEnumerator : IEnumerator<Book>
{
    private List<Book> booksList;
    private int index = -1;
    public MyEnumerator(IEnumerable<Book> books, Predicate<Book> filter)
    {
        booksList = books.ToList().FindAll(filter);
    }
    public Book Current
    {
        get
        {
            try
            {
                return booksList[index];
            }
            catch (Exception)
            {
                throw new InvalidOperationException();
            }
        }
    }
    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }
    public bool MoveNext()
    {
        index++;
        return index < booksList.Count;
    }

    public void Reset() => index = -1;

    public void Dispose() => booksList.Clear();

}
public class MyUtils
{
    public static List<Book> GetFiltered(IEnumerable<Book> books, Predicate<Book>? filter = null)
    {
        Library library = new Library(books);
        List<Book> filteredLst = new List<Book>();

        library.Filter = filter ?? (x => true);

        foreach (Book item in library)
        {
            filteredLst.Add(item);
        }

        return filteredLst;
    }
}
