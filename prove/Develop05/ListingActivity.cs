using System;
using System.Collections.Generic;
using System.Threading;
class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _responses;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>
        {"What are you grateful for?", "List your favorite hobbies.","What achievements are you proud of?",
            "What makes you feel calm?", "What brings you joy?", "when did you feel the spirit this week?"};
        _responses = new List<string>();
    }
    public void Run()
    {
        
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine($">{prompt}\n");
        ShowSpinner(4);
        
        Console.WriteLine($"You have a total of {_duration} seconds to list your thoughts. Enter a response or type 'done' to finish");
        GetListFromUser();

        Console.WriteLine($"\nYou entered {CountResponses()} items");
        DisplayEndingMessage();
         
    }
    public string GetRandomPrompt() 
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
    private void GetListFromUser() 
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        string response;
        while (DateTime.Now < endTime)
        {
            Console.Write(" ");
            response = Console.ReadLine();
            if (response.ToLower() == "done")
            {
                break;
            }
           _responses.Add(response); 
        }
    }
    private int CountResponses()
    {
        return _responses.Count;
    }
}