using System;

class Program
{
    static void Main(string[] args)
    {
    
        Console.Write("What is your grade percentage? ");
        string percentInput = Console.ReadLine();
        int percentage = int.Parse(percentInput);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
           letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Grade: {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("You passed.");
        }
        else
        {
            Console.WriteLine("You did not pass -- but keep trying, dawg. I believe in you.");
        }

        /* JUST THE STUDYING BIT
        string valueInText = "42";
        // int.Parse does NOT like non-number 
        // characters in the string. sad :(
        int number = int.Parse(valueInText);
        number += 1;

        Console.Write(number); 
        // Output: 43 
        // because IT'S AN INTEGER NOW   

        int number = 42;
        string textVersion = number.ToString(); 
        // turns an integer to a string. */

    }
}