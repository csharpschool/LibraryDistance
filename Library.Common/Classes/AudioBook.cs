using Library.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Common.Classes
{
    public class AudioBook : IBook
    {
        public int Id { get; init; }
        public string ISBN { get; init; }
        public string Title { get; set; }
        public string Description { get; set; }

        public AudioBook(int id, string isbn, string title, string descr)
        {
            Id = id;
            ISBN = isbn;
            Title = title;
            Description = descr;
        }


        public int Listen()
        {
            throw new NotImplementedException();
        }
    }
}
