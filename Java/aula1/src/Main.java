import java.util.Locale;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        BookModel book1 = new BookModel("title", "isbm", "author", "genre", 1);
        System.out.println(book1);

        book1.title = "Java Development";
        book1.isbm = "123456789";
        book1.author = "Linux torvalds";
        book1.genre = "Programming";
        book1.pages = 1000;
        book1.borrowed = false;

        System.out.println(book1);
    }
}
