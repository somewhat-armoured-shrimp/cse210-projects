using System;

// i added a special animation method to use for the breathing
// activity exclusively.
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        int menuInput = 0;

        while (menuInput != 4)
        {
            Console.WriteLine("Welcome to the 'Kinda Not Panicked or Stressed' app:");
            Console.WriteLine("    1. Start breathing activity\n    2. Start reflecting activity\n    3. Start listing activity\n    4. Quit");
            Console.Write("Select a choice from the menu: ");
            menuInput = int.Parse(Console.ReadLine());

            if (menuInput == 1)
            {
                Console.Clear();

                BreathingActivity breathingAct = new BreathingActivity("Breathing", "This activity is to help you breathe good, it's something kinda like what they call a 'whim huff', or something like that.");

                breathingAct.Run();

                Console.Clear(); // ¯\_(ツ)_/¯ i guess everything
                // will be bracketed by these
            }

            else if (menuInput == 2)
            {
                Console.Clear();

                ReflectingActivity reflectingAct = new ReflectingActivity("Reflection", "This activity is for when you don't want to feel like you suck, so you decide to remember some nice things about yourself. Good luck!!");

                reflectingAct.Run();

                Console.Clear();

            }

            else if (menuInput == 3)
            {
                Console.Clear();

                ListingActivity listingAct = new ListingActivity("Listing", "This activity is for when you don't want to feel everything around you sucks, so you list off nice things about your life. Good luck lmao");

                listingAct.Run();

                Console.Clear();

            }

            else if (menuInput == 4)
            {
                break;
            } 



        }
    }
}