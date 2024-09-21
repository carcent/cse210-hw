using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");

        string response = Console.ReadLine();
        
        int grade = int.Parse(response);

        string letter = " ";
        
        if (grade >= 90)
        
        {
            letter = "A";
        }
        
        else if (grade >= 80)
        
        {
            letter = "B";
        }
        
        else if (grade >= 70)
        
        {
            letter = "C";
        }
        
        else if (grade >= 60)
        
        {
            letter = "D";
        }
        
        else      
        {        
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");

        if (grade < 70)
        {
            Console.WriteLine("You didn't meet the requirements to pass the class. Don't let one fall determine your life! You'll do great next time.");
        }
        else
        {
            Console.WriteLine("Congratulations! You have pass your course. with effort everything is possible.");
        }
    }
}