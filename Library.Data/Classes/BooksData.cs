using Library.Common.Classes;
using Library.Common.Interfaces;
using System.Reflection.PortableExecutable;

namespace Library.Data.Classes;

public class BooksData : IData
{
    //List<IBook> Books { get; set; }
    List<IBook> _books = new();
    HttpReader _reader;
    public BooksData(HttpReader reader)
    {
        _reader = reader;
        

        //_books.Add(new Book(1, "12345", "Title 1", "Descr 1"));
        //_books.Add(new AudioBook(10, "9867", "Title 1", "Descr 1"));
    }

    public async Task LoadBookData()
    {
        //_books = await _reader.ReadFile("sample-data/book-data.json");
        _books = await _reader.ReadFile<Book>("sample-data/book-data.json");
        _books.AddRange(await _reader.ReadFile<AudioBook>("sample-data/audio-book-data.json"));
    }

    public List<IBook> GetBooks() => _books;
}
