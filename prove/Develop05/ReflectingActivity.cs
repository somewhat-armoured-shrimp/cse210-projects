
class ReflectingActivity : Activity
{   // copying 👍
    private List<string> _prompts = new List<string>(new string[] {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless.", "Think of a time when you completely embarrassed yourself in front of your peers."});
    private List<string> _questions = new List<string>(new string[] {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"});

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        // AHHHH UHHUHHHHHHHHHHHHHHHHHHHH NOBODY'S HERE 
    }

    public void Run()
    {   
        DisplayStartingMessage();
        int seconds = int.Parse(Console.ReadLine()); 

        Console.Clear();
        Console.Write("Get Ready... ");
        ShowCountDown(5);
        Console.Clear();

        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Clear();
        ShowSpinner(5);
        Console.Clear();

        DisplayQuestions(seconds);

        DisplayEndingMessage();
        ShowSpinner(5);

    }
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomPrompt = randomGenerator.Next(_prompts.Count);

        return _prompts[randomPrompt];
    }
    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int randomQuestion = randomGenerator.Next(_questions.Count);
        
        return _questions[randomQuestion];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"\n~*~ {GetRandomPrompt()} ~*~\n");
    }
    public void DisplayQuestions(int seconds)
    {   
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        // le simple core version
        foreach (string question in _questions)
        {   
            if (DateTime.Now >= endTime)
            {
                break;
            }

            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(5);
            Console.WriteLine();
            
        }
         
    }
}