using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Patty Smith", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        
        MathAssignment mathAssignment = new MathAssignment("Ben Andjerrys II", "Logarithms", "6.3", "11-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Dave Dave", "Creative Writing", "Bible 2");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}