using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Assignment assignment = new Assignment("John Doe", "Story homework");
       Console.WriteLine(assignment.GetSummary());
       

        MathAssignment m1 = new MathAssignment("Peter", "Math", "8.3", "8-10");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());

        WritingAssignment w1 = new WritingAssignment("Paul", "The Victorian era", "mm");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());

    }
}