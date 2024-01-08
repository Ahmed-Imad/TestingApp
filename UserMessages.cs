using System.Data.SqlTypes;

namespace TestingApp;

public static class UserMessages
{
    public static void PrintHeader()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("           WELCOME TO THE FUN WIZARD APP!");
        Console.WriteLine("--------------------------------------------------------\n");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void WelcomeUserName (string fullName)
    {
        Console.ForegroundColor= ConsoleColor.DarkGreen;
        Console.WriteLine($"WELCOME {fullName.ToUpper()}");
        Console.ForegroundColor= ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------");
    }

    public static void CopyWrite()
    {
        Console.WriteLine();
        Console.WriteLine("----------------------------------");
        Console.WriteLine("This App was build by Ahmed Fattal");
    }

}
