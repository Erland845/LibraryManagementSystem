using System;

public class Book
{
    private string title;
    private string author;
    private string isbn;
    private int publicationYear;
    public Book(string initialTitle, string initialAuthor, string initialIsbn, int PublicationYear)
    {
        title = initialTitle;
        author = initialAuthor;
        isbn = initialIsbn;
        publicationYear = PublicationYear;
    }
    public string GetTitle()
    {
        return title;
    }
    public void SetTitle(string newtitle)
    {
        title = newtitle;
    }
    public string GetAuthor()
    {
        return author;
    }
    public void SetAuthor(string newauthor)
    {
        author = newauthor;
    }
    public string GetIsbn()
    {
        return isbn;
    }
    public void SetIsbn(string newisbn)
    {
        isbn = newisbn;
    }
    public int GetPublicationYear()
    {
        return publicationYear;
    }
    public void SetPublicationYear(int newpublicationYear)
    {
        publicationYear = newpublicationYear;
    }
    public void PrintBook()
    {
        Console.WriteLine($"Title: {title}, Author: {author}, ISBN: {isbn}, Publicationyear: {publicationYear}");
    }
}

