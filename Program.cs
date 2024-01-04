PrintHeader();

// Get and display user's full name
Console.ForegroundColor = ConsoleColor.White;
string fullName = GetUserFullName();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"WELCOME MR. {fullName}\n");

// Perform multiplication operation
try
{
    double result = GetUserNumber();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"THE RESULT OF MULTIPLYING FIRST NUMBER AND SECOND NUMBER IS: {result}\n");
}
catch (FormatException)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("UNABLE TO PARSE THE FIRST OR SECOND NUMBER!\n");
}

// Ask for user's opinion
Console.ForegroundColor = ConsoleColor.White;
Console.Write("DO YOU LIKE THE APP? ");
string input = Console.ReadLine()?.ToLower() ?? "";

// Respond based on user input
Console.ForegroundColor = ConsoleColor.Magenta;
switch (input)
{
    case "yes" or "yeah" or "sure":
        Console.WriteLine("THANKS!");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    case "no" or "nah":
        Console.WriteLine("NOT A PROBLEM!");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    case "not really" or "somehow":
        Console.WriteLine("OK! I GOT YOU.");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    case "exit":
        Console.Clear();
        Console.WriteLine("EXITING THE APP. GOODBYE!");
        Console.ForegroundColor = ConsoleColor.White;
        Environment.Exit(0);
        break;
    default:
        Console.Clear();
        Console.WriteLine("I DON'T UNDERSTAND THAT! EXITING THE APP.");
        Console.ForegroundColor = ConsoleColor.White;
        break;
}


static void PrintHeader()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("WELCOME TO THE FUN WIZARD APP!");
    Console.WriteLine("--------------------------------------------------------\n");
    Console.ForegroundColor = ConsoleColor.White;
}

static string GetUserFullName()
{
    string? firstName, lastName;

    do
    {
        Console.Write("PLEASE ENTER YOUR FIRST NAME (A-Z/a-z): ");
        firstName = Console.ReadLine()?.Trim();
    } while (string.IsNullOrWhiteSpace(firstName));

    do
    {
        Console.Write("PLEASE ENTER YOUR LAST NAME (A-Z/a-z): ");
        lastName = Console.ReadLine()?.Trim();
    } while (string.IsNullOrWhiteSpace(lastName));

    return $"{firstName} {lastName}";
}

static double GetUserNumber()
{
    double firstNumber, secondNumber;

    while (true)
    {
        Console.Write("PLEASE ENTER FIRST NUMBER: ");
        string? firstInput = Console.ReadLine();

        if (double.TryParse(firstInput, out firstNumber))
            break;

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("INVALID INPUT. PLEASE ENTER A VALID NUMBER.\n");
        Console.ForegroundColor = ConsoleColor.White;
    }

    while (true)
    {
        Console.Write("PLEASE ENTER SECOND NUMBER: ");
        string? secondInput = Console.ReadLine();

        if (double.TryParse(secondInput, out secondNumber))
            break;

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("INVALID INPUT. PLEASE ENTER A VALID NUMBER.\n");
        Console.ForegroundColor = ConsoleColor.White;
    }

    return firstNumber * secondNumber;
}