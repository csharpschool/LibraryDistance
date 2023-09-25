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
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public void Change(string title, string descr) =>
            (Title, Description) = (title, descr);

        public Book(int id, string isbn, string title, string description)
        {
            Id = id;
            ISBN = isbn;
            Change(title, description);
        }

        public int TurnPage()
        {
            throw new NotImplementedException();
        }
    }
}
