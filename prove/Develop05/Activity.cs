class Activity
{
    private string _name;
    private string _description;
    // kill private int _duration?

    // AHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH
    // ILL UNCOMMENT YOU IF I NEED YOU OKAY SHUT UP
    // :3 i needed it or it was nice
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        // _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}.");
        Console.WriteLine($"\n{_description}\n");
        Console.Write($"How long, in seconds, would you like this activity to last? "); 
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! YOU DID IT");
    }
    // AY YE I KNEW IT YEA 
    public void ShowSpinner(int seconds) 
    {
        // list of the animation frames
        List<string> spinnerIcons = new List<string>();
        spinnerIcons.Add("|");
        spinnerIcons.Add("/");
        spinnerIcons.Add("_");
        spinnerIcons.Add("\\");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0; // defined uwu

        // it only likes DateTime.Now. HATES startTime variable :(
        while (DateTime.Now < endTime)
        {
            string icon = spinnerIcons[i]; // telling the loop that icon is a thing index thing
            Console.Write(icon);
            Thread.Sleep(333); // literally three FPS lmao slow 
            Console.Write("\b \b"); // dawg flopping around

            i++; // ADVANCE THE ICON SO THAT IT ACTUALLY GOES THROUGH
            // THE INDEX GUYS INSTEAD OF JUST REPRINTING THE FIRST ITEM 
            // OVER and over and over and over again until you DIE

            // if 'i' is ever greater or equal to the number of items
            // in spinnerIcons,,, 
            if (i >= spinnerIcons.Count)
            {
                // ,,,'i' goes back to zero to start all over again :)
                i = 0;
                // so it can go on regardless of how long you want  
                // endTime to be. pretty solution

            // BASICALLY REPEATS YOUR FRAMES FOR AS LONG AS YOU WANT
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        // i never remember how regular for loops work in c# ok
        // start variable i at 5
        // as long as variable i is greater than 0,
        // decrease variable i by 1 every loop or something 
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // counting in milliseconds
            Console.Write("\b \b"); // print
            // back arrow, space, back arrow for deletion of a single
            // character BY replacing the character with a space
        }
    }
}