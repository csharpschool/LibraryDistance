namespace Library.Common.Interfaces;

public interface IBook
{
    public int Id { get; init; }
    public string ISBN { get; init; }
    public string Title { get; set; }
    public string Description { get; set; }
    //public string Author { get; set; }
}
