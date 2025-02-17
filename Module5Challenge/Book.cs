public class Book
{
    public string Title { get; set; } // {get;set} is read and write perm
    public string Author { get; set; }
    public string ISBN { get; set; }

    public Book(string title, string author, string isbn) // constructor
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }
    public override string ToString() // override
    {
        return $"{Title} by {Author} (ISBN: {ISBN})";
    }
}