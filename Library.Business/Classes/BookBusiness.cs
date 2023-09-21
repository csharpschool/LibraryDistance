using Library.Common.Interfaces;

namespace Library.Business.Classes;

public class BookBusiness
{
    IData _data;

    public BookBusiness(IData data)
    {
        _data = data;
    }

    public List<IBook> Books => _data.GetBooks();
}
