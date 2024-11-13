using System;
using System.ComponentModel;
using System.Data;
// i dont know where these came from but they might be important idk 
// i have no idea 

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume resume1 = new Resume();
        resume1._name = "Brit Ain";

        // adding all the jobs to the cool list i made SO THERE'S
        // ACTUALLY SOMETHING IN IT
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();

    }
}