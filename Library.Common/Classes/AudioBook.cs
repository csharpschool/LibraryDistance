using Library.Common.Interfaces;

namespace Library.Common.Classes
{
    public class AudioBook : IBook
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public AudioBook(int id, string isbn, string title, string description)
        {
            Id = id;
            ISBN = isbn;
            Title = title;
            Description = description;
        }


        public int Listen()
        {
            throw new NotImplementedException();
        }
    }
}
