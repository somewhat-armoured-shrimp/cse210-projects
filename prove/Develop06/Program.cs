using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hey welcome to Glinda's Grievously Guilt-ridden Goal Game (Beta)");
        Console.WriteLine("Your name is: Xx_greg_xX\n(We don't have the technology to give you a customisable username lmao soz)");

        GoalManager goalManager = new GoalManager();

        goalManager.Start();

        
    }
}