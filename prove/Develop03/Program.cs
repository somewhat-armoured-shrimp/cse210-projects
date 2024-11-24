using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // I'm not doing multiple passages. I don't know why
        // I had to accomodate for multiple passages if it wasn't a
        // requirement but it's not and it's already late and I
        // wasted a lot of time trying to implement it :)) HAHAHAHAH
        Reference reference = new Reference("Psalms", 6, 6, 7); // me when coding 
        Scripture scripture = new Scripture(reference, "I am weary with my groaning; all the night make I my bed to swim; I water my couch with my tears. Mine eye is consumed because of grief; it waxeth old because of all mine enemies.");
        // 

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nWelcome to the 'program' :) press Enter to continue or type 'quit' to be a quitter:");
            string input = Console.ReadLine();

            if (input == "")
            {

                scripture.HideRandomWords(4);
            }
            else if (input == "quit")
            {
                break;
            }
        }
    }
}