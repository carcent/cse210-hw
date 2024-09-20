using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");

        string response = Console.ReadLine();
        
        int grade = int.Parse(response);
        
        if (grade >= 90)
        
        {
            Console.WriteLine("A");
        }
        
        else if (grade >= 80)
        
        {
            Console.WriteLine("B");
        }
        
        else if (grade >= 70)
        
        {
            Console.WriteLine("C");
        }
        
        else if (grade >= 60)
        
        {
            Console.WriteLine("D");
        }
        
        else 
        
        {        
            Console.WriteLine("F");
        }

        if (grade <= 70)
        {
            Console.WriteLine("You didn't meet the requirements to pass the class. Don't let one fall determine your life! You'll do great next time");
        }
        else
        {
            Console.WriteLine("Congratulations! You have pass your course. with effort everything is possible");
        }
    }
}