using System;

namespace LibraryManagementSystem.Classes;

public class Book(string title, string author)
{
    public Guid Id = new();
    public string Title = title;
    public string Author = author;
    public bool IsAvailable = true;

    public override string ToString()
    {
        return $"{Title} by {Author}, Available: {IsAvailable}";
    }
}
