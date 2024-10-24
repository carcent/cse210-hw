using System;
using System.Collections.Generic;
using System.Security.Cryptography;

class Program
{

    static void Main(string[] args)
    {
        string filePath = "C:/Users/carli/OneDrive/Documentos/byui/cse210-hw/prove/Develop03/scriptures.txt";
        string[] lines = File.ReadAllLines(filePath);

        foreach (var line in lines)
        {
            var parts = line.Split(new[] { ' ' },4);
            if (parts.Length < 4) continue;
            string book = parts[0];

            var referencePart = parts[1].Split(':');
            if (referencePart.Length <2) continue;

            if (int.TryParse(referencePart[0], out int chapter) && int.TryParse(referencePart[1], out int verse))
            {
                string text = parts[3];
            
                Reference reference = new Reference(book, chapter, verse);

                Scripture scripture = new Scripture(reference, text);   

                Console.WriteLine("Hello! We are going to learn a new scripture together!"); 
                Console.WriteLine("Press 'enter' to hide words from the scripture, if you want to quit press 'Esc'");
        
                while (true)
                {
                    var key = Console.ReadKey(true).Key;

                    if (key ==ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.WriteLine(" ");
                        Console.WriteLine(reference.GetDisplayText());
                        Console.WriteLine(scripture.GetDisplayText());
        
                        scripture.HideRandomWords(3);
                        Console.WriteLine("");
                        Console.WriteLine("Press 'enter' to continue,  press 'Esc' to quit");
                        Console.WriteLine("");
                        if( scripture.IsCompletelyHidden())
                        {
                            Console.Clear();
                            Console.WriteLine("All words are hidden");
                            break;
                        }   
                    }
                    else if(key == ConsoleKey.Escape)
                    {
                        Console.WriteLine("Come back when you want to practice!");
                        return;
                    }
                }
            }   
        }
    
    }
}