public class BookModel {

    // attributes - properties
    String title;
    String isbm;
    String author;
    String genre;
    int pages;
    boolean borrowed;

    // opereations - methods
    // what is returned when printing the object
    public String toString(){
        return title + ", " + author + ", " + borrowed;
    }

    // make this attributes required when creating a new object
    public BookModel(String title, String isbm, String author, String genre, int pages) {
        this.title = title;
        this.isbm = isbm;
        this.author = author;
        this.genre = genre;
        this.pages = pages;
        this.borrowed = false;
    }

}
