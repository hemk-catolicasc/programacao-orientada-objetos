namespace CyberTime
{
    internal class Program
    {   
        static void Main()
        {
            Screen myScreen = new Screen(ConsoleColor.Green, ConsoleColor.Black);
            
            myScreen.ScreenSetup();
            myScreen.FrameAssembly(0,0,79,24);
            myScreen.CenterText("Cyber Control", 1, 0, 79);
            
            ClientModel c1 = new ClientModel();
            c1.Name = myScreen.Ask("Client's name: ", 5, 30);
            myScreen.CenterText(c1.Name, 6, 0, 79);
            
            Console.ReadKey();
        }
    }
}