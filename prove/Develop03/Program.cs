using System;
using System.Security.Cryptography;

class Program
{

    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma", 39, 9, 9);
        Scripture scripture = new Scripture(reference, "Now my son, I would that ye should repent and forsake your sins, and go no more after the lusts of your eyes, but cross yourself in all these things; for except ye do this ye can in nowise inherit the kingdom of God. Oh, remember, and take it upon you, and cross yourself in these things.");

       
        Console.WriteLine("Hello! We are going to learn a new scripture together!"); 
        Console.WriteLine("Press 'enter' to hide words from the scripture, if you want to quit press 'Esc'");
        
        while (true)
        {
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            var key = Console.ReadKey(true).Key;

            if (key ==ConsoleKey.Enter)
            {
                scripture.HideRandomWords(3);

                if( scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine("All words are hidden");
                    break;

                }

                
            }
            else if(key == ConsoleKey.Escape)
            {
                break;
            }


        }
    
    
    }
}