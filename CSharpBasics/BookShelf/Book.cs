using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShelf
{
    public class Book
    {
        public string title, author, description;
        public int pages;
        public Book(string aTitle, string aAuthor, string aDescription, int aPages)
        {
            this.title = aTitle;
            this.description = aDescription;
            this.author = aAuthor;
            try
            {
                this.pages = aPages;
            }
            catch (Exception e)
            {
                Console.WriteLine("You tried to pass something weird into pages. See error message: \n" + e);
            }
        }

        public string displayBook()
        {
            string display = "Title: " + title + "\nAuthor: " + author + "\nDescription: " + description + "\nPages: " + pages;
            return display;
        }
    }
}