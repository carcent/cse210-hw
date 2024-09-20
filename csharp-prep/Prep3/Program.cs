using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?");
        string number = Console.ReadLine();
        int MagicNumber = int.Parse(number);

        Console.Write("What is your guess?");
        string answer = Console.ReadLine();
        int guess = int.Parse(answer);

        if (MagicNumber > guess)
        {
            Console.Write("Higher");
        }

        if (MagicNumber < guess)
        {
            Console.Write("Lower");
        }

        if (MagicNumber == guess)
        {
            Console.Write("You guessed it!");
        }
    }
}