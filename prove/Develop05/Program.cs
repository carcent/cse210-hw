using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        while (number != 4)
        {
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            number = int.Parse(choice);
        
            if (number == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (number == 2)
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (number ==3)
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (number == 4)
            {
                Console.WriteLine("Quitting the program. Goodbye!");
            }
        else
        {
            Console.WriteLine("Invalid choice. Please select a valid option.");
        }
        } 
    }   
    
}
