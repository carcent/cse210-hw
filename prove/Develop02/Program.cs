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

        

        Prompts prompts = new Prompts();
        

        List<string> _prompts = new List<string>();
        
        _prompts.Add("Is there something you would like to change that you did today?");
        _prompts.Add("Did you meet anyone today?");
        _prompts.Add("Did you find an opportunity to share the gospel?");
        _prompts.Add("How was your interaction with others today?");
        _prompts.Add("Were you able to share your testimony??");
        
                
        
        Console.WriteLine("Hello! this is your Personal Journal! You will have a list of options Choose the corresponding number");

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

            //add entry
            if (number == 1)
            {
                Random rnd = new Random();
                int prompt = rnd.Next(_prompts.Count);

               


                Console.WriteLine(_prompts[prompt]);
                string question = _prompts[prompt];
                string response = Console.ReadLine();    
                
                Entry e1 = new Entry();
                e1._entryText = response;

                DateTime currentDate = DateTime.Now;
                string dateTime = currentDate.ToString();

                e1._date = dateTime;
                e1._promptText = question;
                e1.DisplayEntry(); 

               Journal journal = new Journal();
               journal.AddEntry(e1);
               

               
                          

                               
            }
            //display entries
            else if (number ==2)
            {

            Journal display = new Journal();
            display.DisplayAll();



            }
            //load journal
            else if (number ==3)
            {
                Console.WriteLine("What is the file name that you want to load your Journal from?");
                string filename = Console.ReadLine();  

                Journal load = new Journal();
                load.LoadFromfile(filename);
                
            }
            //Save last entry
            else if (number ==4)
            {
                Console.Write("What is the file name that you want to save your Journal?");
                string filename = Console.ReadLine();

                Journal save = new Journal();
                save.SaveToFile(filename);
                

            }



        }
    }

}