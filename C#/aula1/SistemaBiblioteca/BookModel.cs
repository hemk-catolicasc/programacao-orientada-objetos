using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class BookModel
    {
        // Attributes - Properties
        public string title;
        public string isbm;
        public string author;
        public string genre;
        public int pages;
        public bool borrowed;


        // Operations - Methods
        // Make this attributes required when creating a new book
        public BookModel(string title, string isbm, string author, string genre, int pages)
        {
            this.title = title;
            this.isbm = isbm;
            this.author = author;
            this.genre = genre;
            this.pages = pages;
            this.borrowed = false; // Default value for borrowed
        }
    }
}
