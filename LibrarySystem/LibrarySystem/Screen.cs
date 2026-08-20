namespace LibrarySystem;

internal class Screen
{
    // Attributes
    private ConsoleColor _textColor;
    private ConsoleColor _backColor;

    // Properties
    public ConsoleColor TextColor
    {
        get { return _textColor; }
        set { _textColor = value; }
    }

    public ConsoleColor BackColor
    {
        get { return _backColor; }
        set { _backColor = value; }
    }
    
    // Constructor Methods
    public Screen()
    {
        this.TextColor = ConsoleColor.Green;
        this.BackColor = ConsoleColor.Yellow;
    }
    
    public Screen(ConsoleColor text, ConsoleColor back)
    {
        this.TextColor = text;
        this.BackColor = back;
    }
    
    // Util Methods 
    public void CenterText(string text, int line, int initColumn, int finalColumn)
    {
        int column = initColumn + ((finalColumn -initColumn-text.Length) / 2);
        Console.SetCursorPosition(column, line);
        Console.Write(text);
    }

    public string Ask(string text, int line, int column)
    {
        string answer = "";
        
        Console.SetCursorPosition(column, line);
        Console.Write(text);
        answer = Console.ReadLine();
        
        return answer;
    }

    public void FrameAssembly(int initColumn, int initLine, int finalColumn, int finalLine)
    {
        int column, line;

        this.ClearArea(initColumn, initLine, finalColumn, finalLine);
        
        // horizontal lines
        for (column = initColumn; column <= finalColumn; column++)
        {
            Console.SetCursorPosition(column, initLine);
            Console.Write("="); //205
            Console.SetCursorPosition(column, finalLine);
            Console.Write("="); //205
        }
        
        // vertical lines
        for (line = initLine; line <= finalLine; line++)
        {
            Console.SetCursorPosition(initColumn, line);
            Console.Write("||"); //106
            Console.SetCursorPosition(finalColumn, line);
            Console.Write("||"); //106
        }
        
        // corners
        Console.SetCursorPosition(initColumn, initLine);
        Console.Write("||");  //201
        Console.SetCursorPosition(initColumn, finalLine);
        Console.Write("||"); //200
        Console.SetCursorPosition(finalColumn, initLine);
        Console.Write("||"); //187
        Console.SetCursorPosition(finalColumn, finalLine);
        Console.Write("||"); //188
    }

    public void ScreenSetup()
    {
        Console.ForegroundColor = this.TextColor; 
        Console.BackgroundColor = this.BackColor;
        Console.Clear();
    }

    public void ClearArea(int initColumn, int initLine, int finalColumn, int finalLine)
    {
        for (int column = initColumn; column <= finalColumn; column++)
        {
            for (int line = initLine; line <= finalLine; line++)
            {
                Console.SetCursorPosition(column,  line);
                Console.Write(" ");
            }
        }
    }
}