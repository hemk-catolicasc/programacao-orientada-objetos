using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BookModel book1;
            book1 = new BookModel();

            BookModel book2 = new BookModel();

            book1.title = "Java Development";
            book1.isbm = "123456789";
            book1.author = "Linux torvalds";
            book1.genre = "Programming";
            book1.pages = 1000;
            book1.borrowed = false;

            book2.title = "C# Development";
            book2.isbm = "123123123";
            book2.author = "Microsoft";
            book2.genre = "Programming";
            book2.pages = 999;
            book2.borrowed = false; 


            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Book 1 Title: " + book1.title);

            Console.SetCursorPosition(10, 6);
            Console.WriteLine("Book 2 Title: " + book2.title);
        }
    }
}
