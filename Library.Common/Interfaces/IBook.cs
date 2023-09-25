﻿namespace Library.Common.Interfaces;

public interface IBook
{
    public int Id { get; set; }
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    //public string Author { get; set; }
}
