using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new CyclingActivity("Cycling", "25 December 2024", 30, 3));
        activities.Add(new SwimmingActivity("Swimming", "29 November 2024", 30, 10));
        activities.Add(new RunningActivity("Running", "1 April 2024", 30, 3));


        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}