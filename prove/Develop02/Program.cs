using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();


        int menuNav = 0;

        while (menuNav != 5)
        {
            Console.WriteLine("WELCOME TO YOUR WEIRD JOURNAL.\nSELECT ONE OF THE FOLLOWING CHOICES:");
            Console.WriteLine("1. Write New Entry\n2. Display Entries\n3. Save\n4. Load\n5. Quit like a coward");
            menuNav = int.Parse(Console.ReadLine());

            if (menuNav == 1)
            {
                PromptGenerator randPrompt = new PromptGenerator();
                string promptText = randPrompt.GetRandomPrompt();

                // move? 
                Entry entry = new Entry();
                DateTime currentTime = DateTime.Now;

                entry._date = currentTime;
                entry._prompt = promptText;

                Console.Write($"{entry._date} - Prompt: {entry._prompt}\n> ");
                entry._response = Console.ReadLine();
                Console.WriteLine();

                journal.AddEntry(entry);
            }
            else if (menuNav == 2)
            {
                // HHAHAHAHAHAHAHAHAH
                journal.DisplayAll();
            }
            else if (menuNav == 3)
            {
                Console.WriteLine("What is the file name?");
                string filename = Console.ReadLine();

                journal.Save(filename);
            }

            else if (menuNav == 4)
            {
                Console.WriteLine("Okay what file do you wanna load");
                string filename = Console.ReadLine();

                journal.Load(filename);

            }
        }
    }
}