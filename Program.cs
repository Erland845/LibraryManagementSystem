namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You currently have an empty list for books. Would you like to add a book to your list?");
            bool isAdding = false;
            var input = Console.ReadLine().ToLower();
            Library mylibrary = new Library();
            if (input == "yes" || input == "ok")
            {
                isAdding = true;
                while (isAdding)
                {
                    Console.WriteLine();

                    mylibrary.AddBook();

                    Console.WriteLine("Would you like to add another book?");

                    Console.WriteLine();

                    input = Console.ReadLine().ToLower();

                    if (input != "yes" && input != "ok") 
                    {
                        
                        Console.WriteLine();
                        isAdding = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("No books added to the list");
            }

            mylibrary.DisplayBooks();

            Console.WriteLine();
            Console.WriteLine("Would you like to remove a book from your list?");
            Console.WriteLine();
            bool isRemoving = false;
            input = Console.ReadLine().ToLower();
            if (input == "yes" || input == "ok")
            {
                
                isRemoving = true;
                while (isRemoving)
                {
                    Console.WriteLine();    

                    mylibrary.RemoveBook();

                    Console.WriteLine();
                    Console.WriteLine("Would you like to remove another book from the list?");
                    Console.WriteLine();    

                    input = Console.ReadLine().ToLower();
                    if (input != "yes" && input != "ok")
                    {
                        Console.WriteLine();
                        isRemoving = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("No books removed from your list");
            }
            mylibrary.DisplayBooks();

        }
    }
}