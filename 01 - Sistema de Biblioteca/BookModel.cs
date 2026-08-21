using System.Runtime.CompilerServices;

namespace LibrarySystem
{
    internal class BookModel
    {
        // Attributes
        private string _isbn;
        private string _title;
        private string _author;
        private string _genre;
        private int _pages;
        private bool _borrowed;

        // Properties
        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public int Pages
        {
            get { return _pages; }
            set{ if (value > 0) _pages = value; }
        }

        public bool Borrowed
        {
            get { return _borrowed; }
            set { _borrowed = value; }
        }

        // Constructor with parameters
        public BookModel(string isbn, string title, string author, string genre, int pages)
        {
            this.Isbn = isbn;
            this.Title = title;
            this.Author = author;
            this.Genre = genre;
            this.Pages = pages;
            this.Borrowed = false;
        }

        // Empty constructor
        public BookModel()
        {
            this.Isbn = "";
            this.Title = "";
            this.Author = "";
            this.Genre = "";
            this.Pages = 0;
            this.Borrowed = false;
        }
    }
}
