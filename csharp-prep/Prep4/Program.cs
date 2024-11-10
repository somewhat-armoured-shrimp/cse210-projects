using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // MAKE IT ALL FLOATS WHO CARES AJJJJJh I NEED DINNER
        List<float> numbers = new List<float>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        float numEntry = -1;

        while (numEntry != 0)
        {
            Console.Write("Enter number: ");
            numEntry = float.Parse(Console.ReadLine());
            numbers.Add(numEntry);
        }

        // removing the 0 at the end
        numbers.RemoveAt(numbers.Count - 1); // thanks stack overflow
        // grabbing sum ;)
        Console.WriteLine($"The sum is: {numbers.Sum()}"); 

        float average = numbers.Sum() / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        float biggest = 0;

        foreach (float number in numbers)
        {
            if (number > biggest)
            {
                biggest = number;
            }
        }

        Console.WriteLine($"The biggest number is {biggest}");









        /*
        List<string> words = new List<string>();

        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");

        Console.WriteLine(words.Count);
        /////////////////////////////////////////////////
        // iterating through a list with a foreach loop
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
        // accessing items by index
        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine(words[i]);
        }
        /////////////////////////////////////////////////
        */
    }
}