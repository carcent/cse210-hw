using System;
using System.Runtime;
using System.IO;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
      
        Console.WriteLine("Hello! this is your Personal Journal! You will have a list of options Choose the corresponding number");

        Journal journal = new Journal();

        while (number != 0)
        {
            
            Console.WriteLine("Please choose one of the options");
            Console.WriteLine("1- Write on your Journal");
            Console.WriteLine("2- Display your Journal");
            Console.WriteLine("3- Load your Journal");
            Console.WriteLine("4- Save your last entry");
            Console.WriteLine("0- Quit");
            
            string choice = Console.ReadLine();
            number = int.Parse(choice);

            if (!int.TryParse(choice, out number))
            {
                Console.WriteLine("Invalid Entry. Please enter a number from 0-4");
            }

            Prompts prompts = new Prompts();
            prompts.GetRandomPrompt();

            //add entry
            if (number == 1)
            {
                string question = prompts.GetRandomPrompt();
                Console.WriteLine(question);
                string response = Console.ReadLine();    
                
                Entry e1 = new Entry();
                e1._entryText = response;

                DateTime currentDate = DateTime.Now;
                string dateTime = currentDate.ToString();

                e1._date = dateTime;
                e1._promptText = question;
                e1.DisplayEntry(); 

                journal.AddEntry(e1);

                Console.WriteLine("Entry Added");                               
            }  
            //display entries
            else if (number ==2)
            {
                journal.DisplayAll();
            }
            //load journal
            else if (number ==3)
            {
                Console.WriteLine("What is the file name that you want to load your Journal from?");
                string filename = Console.ReadLine();  

                journal.LoadFromfile(filename);    
            }
            //Save last entry
            else if (number ==4)
            {
                Console.Write("What is the file name that you want to save your Journal?");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
            }
        }
    }
}