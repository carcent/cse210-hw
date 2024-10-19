using System;
using System.Net;

class BreathingActivity: Activity
{
    public BreathingActivity()
    {
    _name = "Breathing Activity";
    _description = "This activity will help you relax by guiding you through a series of breathing exercises. Clear your mind and focus on your breathing";
    
    }
    public void Run()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Console.Clear(); 
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.Clear();
        while (DateTime.Now< endTime)
        {
            Console.Write("Breathe in...");
            ShowCountdown(4);

            Console.Write("\n\nNow breathe out...");
            ShowCountdown(4);

            Console.Write("Breathe in...");
            ShowCountdown(5);

            Console.Write("\n\nNow breathe out...");
            ShowCountdown(5);    
        }
       
        DisplayEndingMessage();
         ShowSpinner(3);
         Console.WriteLine($"\nYou have completed another {_duration} seconds of breathing\n");
    }
}