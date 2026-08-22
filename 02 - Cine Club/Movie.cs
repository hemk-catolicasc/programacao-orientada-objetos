namespace CineClub;

public class Movie
{
    private string _title;
    private string _genre;
    private string _director;
    private int _year;

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Genre
    {
        get { return _genre; }
        set { _genre = value; }
    }

    public string Director
    {
        get { return _director; }
        set { _director = value; }
    }

    public int Year
    {
        get { return _year; }
        set { _year = value; }
    }
    
    public Movie()
    {
        this.Title = "";
        this.Genre = "";
        this.Director = "";
        this.Year = 0;
    }
    
}