using System;

static class Helpers
{

    public static void Line()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("________________________________________");
        Console.ResetColor();
    }

    public static void Head()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("======================================= ");
        Console.ResetColor();
    }

    public static void Write(string text)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("::> " + text);
        Console.ResetColor();
    }

    public static string Read(string msg = "Digite um texto")
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(msg + ": ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        string result = Console.ReadLine();
        Console.ResetColor();
        return result;
    }

    public static int ReadInt(string msg = "Digite um número")
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(msg + ": ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        string result = Console.ReadLine();
        Console.ResetColor();
        return Convert.ToInt32(result);
    }

    public static void Heart()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("  ███████    ███████");
        Console.WriteLine("██████████  ███████████");
        Console.WriteLine("██████████  ███████████");
        Console.WriteLine("███████████████████████");
        Console.WriteLine(" █████████████████████");
        Console.WriteLine("   █████████████████");
        Console.WriteLine("     ████████████");
        Console.WriteLine("        ██████");
        Console.WriteLine("          ██");
        Console.ResetColor();
    }
}