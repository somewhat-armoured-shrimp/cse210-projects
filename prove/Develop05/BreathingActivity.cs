class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        // ???? idk empty. things'll be passed in the parameters outside but it's being USED
    }

    public void Run()
    {
        DisplayStartingMessage();
        int seconds = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.Write("Get ready, breathe with the dots... ");
        ShowCountDown(5);
        Console.WriteLine();

        // ANOTHER ONE
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nFill lungs");
            BreathingAnimation(5);
            Console.Write("\nNow hold it");
            BreathingAnimation(8);
            Console.Write("\nEmpty lungs");
            BreathingAnimation(6);
        }

        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(5);
    }
    // stupidly simple. its beautiful
    public void BreathingAnimation(int seconds)
    {   
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(".");
            Thread.Sleep(1000); 
        }
    }
}