public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {   
        // so each class needs its own display method? IM GLEANING
        Console.WriteLine($"Name: {_name}");
        Console.Write("Jobs: ");

        foreach (Job job in _jobs)
        {
            // calling display for each (WHOAH) job so they 
            // don't feel left out :3
            job.Display();
        }
    }
}