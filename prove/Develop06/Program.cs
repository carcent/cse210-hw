using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        int number = -1;
        while (number != 7)
        {
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create Goal");
            Console.WriteLine(" 2. Record Event");
            Console.WriteLine(" 3. List Goal");
            Console.WriteLine(" 4. Display Score");
            Console.WriteLine(" 5. Save Goals");
            Console.WriteLine(" 6. Load Goals");
            Console.WriteLine(" 7. Quit");
            Console.WriteLine("");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            number = int.Parse(choice);
        
            if (number == 1)
            {
                manager.CreateGoal();
            }
            else if (number == 2)
            {
                manager.RecordEvent();
            }
            else if (number ==3)
            {
                manager.ListGoals();
            }
            else if (number == 4)
            {
                manager.DisplayScore();
            }
            else if (number == 5)
            {
                Console.Write("Enter filename to save: ");
                string saveFile = Console.ReadLine();
                manager.SaveGoals(saveFile);
            }
            else if (number == 6)
            {
                Console.Write("Enter filename to load: ");
                string loadFile = Console.ReadLine();
                manager.LoadGoals(loadFile);
            }
            else if (number == 7)
            {
                Console.WriteLine("Quitting the game! come back soon to save your goals! ");
                Console.WriteLine("By small and simple things are great things brought to pass.");
            }
        else
        {
            Console.WriteLine("Invalid choice. Please select a valid option.");
        }
        } 
    }   
    
}
