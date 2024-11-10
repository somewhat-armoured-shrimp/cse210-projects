using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int numberSquared = SquareNumber(userNumber);

        DisplayResult(userName, numberSquared);

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Message of welcoming :)");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your username: ");
            string name = Console.ReadLine();
            return name;
            
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favourite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        static void DisplayResult(string userName, int numberSquared)
        {
            Console.WriteLine($"{userName}, the square of your number is {numberSquared}");
        }
    }
}