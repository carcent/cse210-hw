using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1,101);
        
        Console.Write("What is your guess?");
        string answer = Console.ReadLine();
        int guess = int.Parse(answer);
        
        while (guess != MagicNumber)
        
        {
            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (MagicNumber > guess)
            {
                Console.WriteLine("Higher"); 
            }

            else if (MagicNumber < guess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}