namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Screen myScreen = new Screen(ConsoleColor.Black, ConsoleColor.Red);
            
            myScreen.ScreenSetup();
            myScreen.FrameAssembly(0,0,79,24);
            myScreen.CenterText("Hello World!", 1, 0, 79);
            
            myScreen.FrameAssembly(5, 3, 30, 10);
            myScreen.CenterText("Book register", 4, 5, 30);
            
            myScreen.FrameAssembly(40, 10, 75, 23);
            myScreen.CenterText("Book list", 11, 40, 75);
            
            myScreen.FrameAssembly(20, 7, 60, 20);
            myScreen.CenterText("Important advices", 8, 20, 60);
            
            Console.ReadKey();
        }
    }
}
