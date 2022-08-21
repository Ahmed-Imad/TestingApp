using System;

namespace TestingApp 
{
      internal class Program
     {
         static void Main(string[] args)
         {
            // the heading >>>
            PrintHeader();
            
            // coloring the text and getting first and last names >>>

                Console.ForegroundColor= ConsoleColor.White;


            //  a new line, printing out first and last name and coloring the text again >>>
                string fullname = GetUserFullName();
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine( "WELCOME MR. " + fullname);
                
                                   

            // a new line, entering the first and second numbers for mulit opration >>>
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    double total =GetUserNumber();
                    Console.WriteLine();
                 
                // make sure the user is using valid inputs by using Parsing the inputs and then doing the multiplication
                                          
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"THE RESULT OF MULTIPLAYING " +
                    $"FIRST NUMBER AND SECOND NUMBER IS: {total}");
                    Console.WriteLine();
                 }
                  
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"NO RESULT!");
                    Console.WriteLine($"UNABLE TO PARSE THE FIRST OR SECOND NUMBER!");
                    Console.WriteLine();
                }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("DO YOU LIKE THE APP? ");
            string? input= Console.ReadLine();
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.Green;
            switch (input)
            {
              
                case "yes":
                case "YES":
                case "yeah":
                case "sure":
                    Console.Write("THANKS!");
                    break;

                case "no":
                case "NO":
                case "nah":
                    Console.Write("NOT A PROBLEM!");
                    break;
                case "not really":
                case "NOT REALLY":
                    Console.Write("OK! I GOT YOU.");
                    break;
                case "exit":
                    Console.Clear();
                    break;
                default: Console.Write("I DON'T UNDERSTAND THAT!");
                    break;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }

        static void PrintHeader()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("WELCOME TO THE FUN WIZARD APP!");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();
        }
        
        static string GetUserFullName()
        {
            Console.Write("PLEASE ENTER YOUR FIRST NAME USE ONLY (A-Z) (a-z): ");
            string? firstName = Console.ReadLine();
            Console.Write("PLEASE ENTER YOUR LAST NAMEUSE ONLY (A-Z) (a-z): ");
            string? lastName = Console.ReadLine();
            
            return firstName + " " + lastName;
        }

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


    }
}