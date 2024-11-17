public class Entry
{
    public DateTime _date;
    public string _prompt;
    public string _response;



    public void Display()
    {
        Console.Write($"{_date} - Prompt: {_prompt}\n> {_response}\n");
        Console.WriteLine();
    }

    public void Save(StreamWriter outputFile)
    {   // each member gets a line so the computer can read it
        // more better.
        outputFile.WriteLine($"{_date}");
        outputFile.WriteLine($"{_prompt}");
        outputFile.WriteLine($"{_response}");
    }

    // each of those lines is read individually as well. lots of 
    // cool parallels 
    public void Load(StreamReader inputFile)
    {   // using Parse on DateTime because it's DateTime and 
        // not a string
        _date = DateTime.Parse(inputFile.ReadLine());
        _prompt = inputFile.ReadLine();
        _response = inputFile.ReadLine();
    }
}