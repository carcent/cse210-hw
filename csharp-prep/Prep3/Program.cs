using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1,101);
        
        
        int guess = 0;
        
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