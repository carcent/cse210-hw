using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
       
        Console.WriteLine("Enter a list of numbers, Type 0 when finished.");
        int number = -1;
       
        while (number != 0)
        {
            Console.Write("Enter number:");
            string answer = Console.ReadLine();
            number = int.Parse(answer);
        
            if (number !=0)
            {
                numbers.Add(number);
            }
        }
        
        int sum = 0;

        foreach (int i in numbers)
        {
            sum+= i;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int MaxNumber = numbers[0];

        foreach (int i in numbers)
            {
                if (i > MaxNumber)
                {
                    MaxNumber = i;
                }
            }
        Console.WriteLine($"The max is: {MaxNumber}");


    }
}