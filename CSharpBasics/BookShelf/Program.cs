using System;

namespace BookShelf
{
    // I want 5 books on my bookshelf.
    class Program
    {
        static void Main(string[] args)
        {
            // we need an array of books.
            object[] bookShelf = new object[5];

            Book book1 = new Book("Mar", "Gar", "Pooper", 10);

            bookShelf[0] = book1;
            bookShelf[1] = new Book("Tim", "Bar", "Peeper", 20);
            bookShelf[2] = new Book("Bim", "Mar", "Poofer", 30);
            bookShelf[3] = new Book("Jim", "Tar", "Puffer", 40);
            bookShelf[4] = new Book("Rim", "Job", "Buffer", 50);
            Console.WriteLine("Book 1: " + bookShelf[0]);
            Console.WriteLine("Book 1: " + book1.displayBook());

            foreach (string book in bookShelf)
            {
                Console.WriteLine(book);
            }

            // place code above
            Console.ReadLine();
        }
    }
}