using System;

public class Library 
{
    private List<Book> booklist;
    public Library()
    {
        booklist = new List<Book>();
    }
    public void AddBook()
    {
        Console.WriteLine("Sumbmit title of the book");
        string title = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Submit the Author of the book");
        string author = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Submit ISBN of the book");
        string isbn = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Submit publicationyear of the book");
        int publicationYear;
        while (!int.TryParse(Console.ReadLine(), out publicationYear))
        {
            Console.WriteLine("Invalid input, please submit a valid year.");
        }
        Console.WriteLine();

        Book newbook = new Book(title, author, isbn, publicationYear);
        booklist.Add(newbook);
    }
    public void RemoveBook()
    {
        Console.WriteLine();
        Console.WriteLine("Enter the title of the book you want to remove");
        Console.WriteLine();

        string titleToRemove = Console.ReadLine();

        int removedCount = booklist.RemoveAll(book => string.Equals(titleToRemove, book.GetTitle(), StringComparison.OrdinalIgnoreCase));
        if (removedCount > 0)
        {
            Console.WriteLine();
            Console.WriteLine($"Removed {removedCount} book(s) with title '{titleToRemove}'.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"No book found with tile '{titleToRemove}'.");
        }
    }
    public void DisplayBooks()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Here's the books in the list:");
        Console.WriteLine();

            foreach (Book book in booklist)
        {
            book.PrintBook();
            Console.WriteLine();
        }
    }
}


