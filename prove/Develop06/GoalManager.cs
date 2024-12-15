class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0; // eh
    }

    public void Start()
    {
        int menu = 0;

        while (menu != 6)
        {
            Console.WriteLine($"\nYou have {_score} points.\n");
            Console.WriteLine("Menu Options:\n    1. Create New Goal\n    2. List Goals\n    3. Save Goals\n    4. Load Goals\n    5. Record Event\n    6. Quit");
            Console.Write("Whaddya wanna do? ");
            menu = int.Parse(Console.ReadLine());

            if (menu == 1)
            {
                CreateGoal();
            }
            else if (menu == 2)
            {
                ListGoalDetails();
            }
            else if (menu == 3)
            {
                Console.WriteLine("Name o' the file? Just make one up.");
                SaveGoals();
            }
            else if (menu == 4)
            {
                Console.WriteLine("Name o' the file? Pretty sure it has to exist this time.");
                LoadGoals();
            }

            else if (menu == 5)
            {
                RecordEvent();
            }
            else if (menu == 6)
            {
                Console.WriteLine("Goodbye Xx_greg_xX. :(");
                break;
            }
        }

    }
    // you return an integer. promoted !! good job
    public int DisplayPlayerInfo()
    {
        return _score;
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            // tell the loop thing that Goal goal is a _goals item
            Goal goal = _goals[i];
            // and every time loop, i go up :]
            Console.WriteLine($"    {i + 1}. {goal.GetGoalName()}");
        }
    }
    public void ListGoalDetails()
    {
        // https://stackoverflow.com/questions/63636569/how-to-add-increasing-numbers-in-front-of-a-list-items-objects-when-outputting-t
        // thanks stack overflow guy
        // I DID HAVE THE FOR STATEMENT PART DOWN THOUGH OKAY I HAD 
        // IT WRITTEN DOWN to a TEE BEFORE I LOOKED IT UP i UNDERSTAND IT
        for (int i = 0; i < _goals.Count; i++)
        {
            // tell the loop thing that Goal goal is a _goals item
            Goal goal = _goals[i];
            // and every time loop, i go up :]
            Console.WriteLine($"{i + 1}. {goal.GetDetailString()}");
        }
    }
    public void CreateGoal()
    {
        int goalType = 0;

        Console.WriteLine("The types o' goals you can do are:\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal");
        Console.Write("So what typa goal you wanna do? ");
        goalType = int.Parse(Console.ReadLine());

        if (goalType == 1)
        {
            Console.WriteLine("What's the name o' your goal? And use a descriptive phrase - don't give it no human name. ");
            string name = Console.ReadLine();

            Console.WriteLine("Now you can get a into a lil' more detail about what you want. ");
            string description = Console.ReadLine();

            Console.WriteLine("How many points you gonna get for this here goal? ");
            int points = int.Parse(Console.ReadLine());

            SimpleGoal simpGoal = new SimpleGoal(name, description, points, false);
            _goals.Add(simpGoal);
        }

        else if (goalType == 2)
        {
            Console.WriteLine("What's the name o' your goal? And use a descriptive phrase - don't give it no human name. ");
            string name = Console.ReadLine();

            Console.WriteLine("Now you can get a into a lil' more detail about what you want. ");
            string description = Console.ReadLine();

            Console.WriteLine("How many points you gonna get for this here goal? ");
            int points = int.Parse(Console.ReadLine());

            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }

        else if (goalType == 3)
        {
            Console.WriteLine("What's the name o' your goal? And use a descriptive phrase - don't give it no human name. ");
            string name = Console.ReadLine();

            Console.WriteLine("Now you can get a into a lil' more detail about what you want. ");
            string description = Console.ReadLine();

            Console.WriteLine("How many points you gonna get for each one o' these goals? ");
            int points = int.Parse(Console.ReadLine());

            Console.WriteLine("How many o' these you gotta accomplish for a bonus? ");
            int targetAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("And how much is that bonus gonna be? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checkGoal = new ChecklistGoal(name, description, points, targetAmount, bonus);
            _goals.Add(checkGoal);
        }
        else
        {
            Console.WriteLine("das not a goal type. what's wrong wich you?");
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("You actually did somethin'? Which one? ");

        ListGoalNames();
        int option = int.Parse(Console.ReadLine());
        // because counting starts at 0
        Goal goal = _goals[option - 1];

        // add points to score
        _score += goal.RecordEvent();

    }
    public void SaveGoals()
    {
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{DisplayPlayerInfo()}");

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }
    public void LoadGoals()
    {
        // loading files is actually unbearable. SAVING is great. 
        // this is abominable.
        string filename = Console.ReadLine();

        // clearing the things for loading purposes
        _goals.Clear();

        string[] lines = System.IO.File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        // foreach lines AFTER the first one...
        foreach (string line in lines.Skip(1))
        {
            // splitting each line into an array of two items:
            // 'left of colon' and 'right of colon'
            string[] parts = line.Split(":");

            // if the first item of parts blahblah specifications
            // for assigning the things back into constructor objects
            if (parts[0] == "SimpleGoal")
            {   
                // split everything right of the colon by their 
                // commas
                string[] fields = parts[1].Split(",");
                // assign each new field part a place in a 
                // SimpleGoal constructor
                Goal loadedGoal = new SimpleGoal(fields[0], fields[1], int.Parse(fields[2]), Convert.ToBoolean(fields[3]));
                // add the new goal to the list to be used as normal
                _goals.Add(loadedGoal);
                
            }
            else if (parts[0] == "EternalGoal")
            {
                string[] fields = parts[1].Split(",");
                Goal loadedGoal = new EternalGoal(fields[0], fields[1], int.Parse(fields[2]));
                _goals.Add(loadedGoal);

            }
            else if (parts[0] == "ChecklistGoal")
            {
                string[] fields = parts[1].Split(",");
                Goal loadedGoal = new ChecklistGoal(fields[0], fields[1], int.Parse(fields[2]), int.Parse(fields[3]), int.Parse(fields[4]));
                _goals.Add(loadedGoal);
            }

        }

    }
}