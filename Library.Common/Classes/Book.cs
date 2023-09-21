using Library.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Common.Classes
{
    public class Book : IBook
    {
        public int Id { get; init; }
        public string ISBN { get; init; }
        public string Title { get; set; }
        public string Description { get; set; }

        public void Change(string title, string descr) =>
            (Title, Description) = (title, descr);

        public Book(int id, string isbn, string title, string descr)
        {
            Id = id;
            ISBN = isbn;
            Change(title, descr);
        }

        public int TurnPage()
        {
            throw new NotImplementedException();
        }
    }
}
