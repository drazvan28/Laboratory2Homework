using System;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Book instances
            Book book1 = new Book("Brave New World", "Aldous Huxley");
            Book book2 = new Book("Moby Dick", "Herman Melville", 635);

            // Check out book1 and return book2
            book1.CheckOut();
            book2.ReturnBook();

            // Print details of both books
            Console.WriteLine(book1);
            Console.WriteLine(book2);
        }
    }
}