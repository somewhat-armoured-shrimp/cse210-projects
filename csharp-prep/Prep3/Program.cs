using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);
        // just telling myself what it is so i dont HAVE to guess.
        Console.WriteLine(magicNum);

        Console.Write("There's a magic number from 1 to 100. \nTake your guess at what it is: ");
       
        int numGuess = int.Parse(Console.ReadLine()); 
        // the sample placed the user input in the while loop 
        // but that's because "What is your guess" is the only
        // question that shows up.
        // in the sample solution, the correct answer print 
        // statement is placed in the else block,
        // whereas mine run first thing 
        // after the while loop stops because numGuess == magicNum 

        // im stealing that int.Parse(Console.ReadLine()) thing though 

        while (numGuess != magicNum)
        {
            if (numGuess > magicNum)
            {
                Console.WriteLine("Lower.");
            }
            else
            {
                Console.WriteLine("Higher.");
            }
            Console.Write("Please try again: ");

            numGuess = int.Parse(Console.ReadLine()); 
        }
        
        Console.WriteLine("omg u did it :)");





        /* JUST THE SMALL HOMEWORK
        string response;
        do
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");

        /////////////////////////////////////////////////////////////
        // counts from 0 to 9
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        // counts from 2 to 20 by two's
        for (int i = 2; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }
        /////////////////////////////////////////////////////////////
        string[] colours = ["blue", "yellow", "green", "fuchsia"];

        foreach (string colour in colours)
        {
            Console.WriteLine(colour);
        }
        /////////////////////////////////////////////////////////////
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        Console.WriteLine(number);
        ///////////////////////////////////////////////////////////// */

    }
}