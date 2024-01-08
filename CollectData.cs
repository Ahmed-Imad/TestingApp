namespace TestingApp;

public class CollectData
{
    // I HAVE NOT DECIDED WHAT I'M GOING TO DO WITH THIS FUNCTION 
    static double GetUserNumber()
    {
        Console.Write("PLEASE ENTER FIRST NUMBER? ");
        string? firstInput = Console.ReadLine();
        Console.Write("PLEASE ENTER SECOND NUMBER? ");
        string? secondInput = Console.ReadLine();
        Double intFNumber = Double.Parse(firstInput!);
        Double intSNumber = Double.Parse(secondInput!);
        Double total = intFNumber * intSNumber;

        return total;
    }
    public static string GetUserFullName()
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

    public static int AskUserQuestions()
    {
        string[] questions = {
         "A cloud weighs around a million tonnes? (yes or no)?",
         "Giraffes are 30 times more likely to get hit by lightning than people?",
         "Identical twins don’t have the same fingerprints?",
         "Animals can experience time differently from humans?",
         "The Sun makes a sound but we can't hear it?",
         "You can actually die laughing? y",
         "A horse normally has more than one horsepower?",
         "Bananas are radioactive?",
         "There are more bacterial cells in your body than human cells?",
         "You don't like the sound of your own voice because of the bones in your head?"
        };

        bool[] answers = new bool[questions.Length];
        bool[] correctAnswers = { true, true, true, true, true, true, true, true, true, true };
        int total = 100;

        for (int i = 0; i < questions.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.WriteLine(questions[i]);
            Console.ForegroundColor = ConsoleColor.White;
            answers[i] = GetYesNoAnswer();
            if (answers[i] != correctAnswers[i])
            {
                total -= 10;
            }

        }
        return total;
    }

    private static bool GetYesNoAnswer()
    {
        string userInput;
        do
        {
            Console.Write("Please answer with 'yes' or 'no': ");
            userInput = Console.ReadLine().Trim().ToLower();
        } while (userInput != "yes" && userInput != "no");

        return userInput == "yes";
    }

    public static bool AskUser()
    {
        string userInput;
        int attempts = 0;
        do
        {
            Console.WriteLine("Would you like to answer funny fact questions? (yes or no)");
            userInput = Console.ReadLine().Trim().ToLower();
            attempts++;
            if (attempts >= 3)
            {
                Console.WriteLine("You have exceeded the maximum number of attempts.");
                break;
            }

        } while (userInput != "yes" && userInput != "no");

        return userInput == "yes";
    }

    public static string RatePerformance(int percentage)
    {

        if (percentage >= 80)
            return " Your rate is Excellent.";
        else if (percentage >= 60)
            return "Your rate is Good.";
        else
            return "Your rate is Not Very Good.";
    }

    public static bool ProcessUserChoice()
    {
        bool userWantsToAnswerQuestions = AskUser();

        if (userWantsToAnswerQuestions)
        {
            // Perform actions for "yes"
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("GREAT! LET'S PROCEED WITH THE FUNNY FACT QUESTIONS!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Okay! maybe next time. Have a great day!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        return userWantsToAnswerQuestions;
    }
}
