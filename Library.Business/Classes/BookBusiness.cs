using Library.Common.Classes;
using Library.Common.Interfaces;
using System.Reflection.PortableExecutable;

namespace Library.Business.Classes;

public class BookBusiness
{
    IData _data;

    public BookBusiness(IData data)
    {
        _data = data;
    }

    public List<IBook> Books => _data.GetBooks();


    public async Task LoadBookData()
    {
        await _data.LoadBookData();
    }
}
