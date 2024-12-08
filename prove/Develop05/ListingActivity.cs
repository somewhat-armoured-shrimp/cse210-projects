class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>(new string[] { "What are some things that make you feel cool?", "Who are the people you appreciate?", "Who are some of your personal heroes?", "When have you felt like a turbo epic sigma?", "Who are the people you've helped this week?" });
    private List<string> _answers = new List<string>(); 
    // new CLUB MEMBER YAAAYYYYYYY because how on earth else

    public ListingActivity(string name, string description) : base(name, description)
    {
        // just empty and sad idk 
    }

    public void Run()
    {
        DisplayStartingMessage();
        int seconds = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.Write("Get Ready... ");
        ShowCountDown(5);
        Console.Clear();

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"\n~*~ {GetRandomPrompt()} ~*~\n");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        // IMPLEMENTING THE TIME LIMIT :3
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        // trusting that it stops when it should. it seems to.
        while (DateTime.Now < endTime)
        {
            GetListButMostlyJustGetTheCount();
        }
        
        Console.WriteLine($"\nYou wrote {GetListButMostlyJustGetTheCount()} things. congart");

        DisplayEndingMessage();
        ShowSpinner(5);
    }
    public string GetRandomPrompt()
    {
        // unironically copy-pasted no change
        Random randomGenerator = new Random();
        int randomPrompt = randomGenerator.Next(_prompts.Count);

        return _prompts[randomPrompt];
    }
    public int GetListButMostlyJustGetTheCount() // i silly today
    {   
        // ugh weird spacing but it's half decent enough
        Console.Write("\n> ");

        string answer = Console.ReadLine();
        _answers.Add(answer);

        _count = _answers.Count; // idk use the member variable 
                                 // or something
        return _count;
    }
}