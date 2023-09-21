using Library.Common.Classes;
using Library.Common.Interfaces;

namespace Library.Data.Classes;

public class BooksData : IData
{
    //List<IBook> Books { get; set; }
    List<IBook> _books = new();

    public BooksData()
    {
        _books.Add(new Book(1, "12345", "Title 1", "Descr 1"));
        _books.Add(new AudioBook(10, "9867", "Title 1", "Descr 1"));
    }

    public List<IBook> GetBooks() => _books;
}
